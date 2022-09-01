# Accord.NET Framework

This project is currently archived. Please fork the project into your own GitHub account if you would like to continue its development.

# Archiving

After 14~15 years of development, the Accord.NET project has finally been archived. I would like to send a big thank you to everyone who has ever comitted, dedicated, or otherwise devoted their time and effort into making this repository better every day. What had started as a project to store knowledge in the form of algorithms and implementations had grown way beyond my expectations since I first joined university and started working on research ~15 years ago.

In the meantime, many things have happened, and the ML landscape had also greatly evolved since then.

However, I pledge you to absolutely not interpret the archiving of this project as a loss. The main goal of this project since day 1 was to crystalize the ML knowledge available at the time in the form of source code and store it under a number of compatible free software licenses. As such, if you would like to, *do not feel afraid of copy and pasting portions of this project into your own implementations*. If I (Cesar De Souza) am the solely implementor of any of the classes you would like to port, I hereby grant you an irrevocable license to do so. If I am not, and the current license of the file you would like to port does not suit your needs, I can help you contact their original developers to help you with the transition.

<pre>
"We reject kings, presidents and voting.  We
   believe in rough consensus and running code"
   -- David Clark
</pre>

All this said. This has been an amazing ride.

Thanks everyone for their ever growing support all those years.

Let's keep in touch,

Cesar



# Installing

To install the framework in your application, please use NuGet. If you are on Visual Studio, right-click on the "References" item in your solution folder, and select "Manage NuGet Packages." Search for Accord.MachineLearning ([or equivalently, Accord.Math, Accord.Statistics or Accord.Imaging depending on your initial goal](https://www.nuget.org/packages?q=accord.net)) and select "Install."

If you would like to install the framework on [Unity3D applications](https://unity3d.com), download the "libsonly" compressed archive from the [framework releases page](https://github.com/accord-net/framework/releases). Navigate to the Releases/Mono folder, and copy the .dll files to the Plugins folder in your Unity project. Finally, find and add the System.ComponentModel.DataAnnotations.dll assembly that should be available from your system to the Plugin folders as well.

## Sample applications

The framework comes with a wide range of sample applications to help get you started quickly. If you downloaded the framework sources or cloned the repository, open the *Samples.sln* solution file in the Samples folder.


# Building

#### With Visual Studio 2015

Please download and install the following dependencies:

- [T4 Toolbox for Visual Studio 2015](https://visualstudiogallery.msdn.microsoft.com/34b6d489-afbc-4d7b-82c3-dded2b726dbc)
- [Sandcastle Help File Builder (with VS2015 extension)](https://github.com/EWSoftware/SHFB/releases)
- [NUnit 3 Test Adapter](https://marketplace.visualstudio.com/items?itemName=NUnitDevelopers.NUnit3TestAdapter)

Then navigate to the Sources directory, and open the *Accord.NET.sln* solution file. Note: the solution includes F# unit test projects that can be disabled/unloaded from the solution in case you do not have support for F# tools in your version of Visual Studio.


#### With Visual Studio 2017

Please download and install the following dependencies:

- [T4 Toolbox for Visual Studio 2017](https://github.com/hagronnestad/T4Toolbox/releases/tag/vs2017-b1)
- [Sandcastle Help File Builder (with VS2017 extension)](https://github.com/EWSoftware/SHFB/releases)
- [NUnit 3 Test Adapter](https://marketplace.visualstudio.com/items?itemName=NUnitDevelopers.NUnit3TestAdapter)
- [Visual C++ Redistributable for Visual Studio 2015](https://www.microsoft.com/en-us/download/details.aspx?id=48145&751be11f-ede8-5a0c-058c-2ee190a24fa6) (both x64 and x86)

Then navigate to the Sources directory, and open the *Accord.NET.sln* solution file. Note: the solution includes F# unit test projects that can be disabled/unloaded from the solution in case you do not have support for F# tools in your version of Visual Studio.


#### With Mono in Linux

```bash
# Install Mono
sudo apt-get install mono-complete monodevelop monodevelop-nunit git autoconf make

# Clone the repository
git clone https://github.com/accord-net/framework.git

# Enter the directory
cd framework

# Build the framework solution using Mono
./autogen.sh
make build
make samples
make test
```

#### With Mono in OS X

```bash
# Install Mono
brew update
brew cask install mono-mdk pkg-config automake

# Clone the repository
git clone https://github.com/accord-net/framework.git

# Enter the directory
cd framework

# Set some environment variables with OSX-specific paths
export PKG_CONFIG_PATH=/Library/Frameworks/Mono.framework/Versions/Current/lib/pkgconfig/
export MONO=/Library/Frameworks/Mono.framework/Versions/Current/bin/mono
export XBUILD=/Library/Frameworks/Mono.framework/Versions/Current/bin/xbuild

# Build the framework solution using Mono
./autogen.sh
make build
make samples
make test
```


