# NetDemo Client

This is a sample application GUI client intended for use with:

- .NET 4.7.2+
- Visual Studio Enterprise 2017

The following info is all you need to create a CI/CD pipeline for this component within Guide-Rails&#174;.

## Pipeline Definition

We've already created a pipeline definition for this client application in `/ci/guide-rails.json`. Once onboarded to Guide-Rails&#174;, your pipeline will consist of the following segments:

- Build - pulls build dependencies (netdemo-sharedlib), compiles, unit tests and packages the application
- Integration - provisions ephemeral testing environment, deploys application dependencies (netdemo-server), installs client application
- Production - no production segment is defined as yet... this can be added via the Guide-Rails&#174; Configuration Console (aka Onboarding)

At the end of a successful pipeline run, users can RDP to the windows machine where the client is installed and run manual user acceptance tests if desired

## Onboarding This Repository

1. Fork this repository and add to your preferred source code management server (Bitbucket, Github, Gitlab, etc.) 
2. Log into Guide-Rails&#174; and head to the Configuration Console (aka Onboarding) and add a new Component
3. In the Component configuration view, choose your source code management server and enter your repository clone URL (https or SSH)
4. Verify the properties described in the rest of this document are set properly in your configuration

### Code Analysis

| Name | Value | Description |
| ---- | ----- | ----------- |
| Run Code Analysis | [&#x2713;] | |
| Source Directories | local-sonar-project.properties | Temporarily set this value, should not need to in the future. Proper usage is not to set this value. |
| Additional Properties Files | local-sonar-project.properties | sonar project properties file |

> **Note: Existing Quality Gates**
>
>If this pipeline fails to pass the build segment because of Quality Gates, you
can override them in the Component settings.

### Properties

No additional properties are required.

### Deployment Files

| Name | Description |
| ---- | ----------- |
| ci/install.ps1 | the script that handles whatever the installation procedure is supposed to be |

### Integration Segment

#### Job Steps

This is where the client application is installed on the machine. By default it runs the installer script which will place the client executable in the program files directory and add a shortcut to the desktop. Additional job steps might do the following:

- Run integration GUI tests
- Publish the GUI installation package to a desired location after the integration tests pass.

#### Instance Groups

Two Instance Groups are added here, in order.

##### netdemo-server

Has these dependencies.

| Release | Version | Job Name | Properties |
| - | - | - | - |
| bosh-dns-windows | latest | bosh-dns-windows | |
| | | | address : ((consul.joinservers)) |
| consul-windows | latest | consul-windows | |
| | | | consul.servicename : ((consul.servicename)) |
| | | | consul.domain : ((consul.domain)) |
| | | | consul.environment : ((consul.environment)) |
| | | | consul.joinservers : ((consul.joinservers)) |
| | | | consul.datacenter : ((consul.datacenter)) |
| | | | calculi.intermediate.cert : grsecret:tls.cert |
| | | | calculi.intermediate.key : grsecret:tls.key |
| | | | consul.server : false |
| netdemo-server | latest | netdemoserver | |

When adding netdemo-server, it will use the default *demoserver.port* value defined in its own component. If you want to override this, you can do this by adding a new *demoserver.port* property under Properties. The data type should be the same as what is in the original netdemo-server component. In general, this *Instance Group* configuration with mimic that of the original component integration segment configuration.

##### ((application.name))

Since it's a GUI application, the dependencies for this can be left blank.

##### Persistence

This setting determines whether or not Guide-Rails® will teardown the environment once the segment completes. By default, this is set to false for Build and testing segments (Isolation, Integration). If you want to the environment to stay up after testing completes, set this to true.
