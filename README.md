# CANTLC

Quantification of cannabinoids with computational assessment of natural products thin-layer chromatography (canTLC)

A. Dabdoub*, Land Grant Program, Central State University, Wilberforce, OH 45384; C. Schluttenhofer, Agriculture Research Development Program, Central State University, Wilberforce, OH 45384

For the last 100 years Cannabis sativa has been classified depending on whos growing it, the purpose and the views of those in power.In recent years since the legalization of Hemp, Measuring THC and other compounds within the plant are necessary to separate it from a legal and non legal plant. One Testing method used to detect cannabinoids like THC and CBD and keep hemp farmers in compliance is thin-layer chromatography (TLC). A major challenge with TLC has been the human interpretation of these testing results. Recent work using Artificial Intelligence and Computers has substantially improved the testing ability of TLC. This work evaluates the use of Computer Image Processing and Machine learning on TLC for the detection of chemicals, creates a standard for the range of colors in these test, and the detection of chemical cannabis compounds. Standard testing methods and equipment can have a equipment cost starting at $35,000, creating a cost to entry barrier for the scientific community, farmers and Researchers. There is also problems with farmers needing to use copious amounts of product which could be saved if they had a way to test themselves.  This Problem led to the creation of an opensource software developed by my professor and I. The application, computational assessment of natural products TLC (canTLC), determines color value, color intensity, and size of spots based on custom and free-to-use software. To make sure it was working and accurate, known concentrations were used to devise a standard curve for quantification of spots based on intensity and size. Unknown samples analyzed with canTLC were comparable with the standards in testing these chemical compounds. Observations indicate standardization of human and digital systems are needed to further fine-tune the methodology. The in-house software with an open source application is available for public download.

Topic Area: Plant Health and Production and Plant Products
currently cant work on this, would love some help. 

All this said. This has been an amazing ride.

Thanks everyone for their ever growing support all those years.

Let's keep in touch,





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


