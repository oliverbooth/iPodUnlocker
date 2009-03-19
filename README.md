# iPod Unlocker
An iPod unlocker app made with Windows Forms and C#

## What is this?
This repository is part of a personal archivist project that I'm in the process of undertaking. I'm going through all of my old projects, and uploading them to GitHub. This is one of those projects. It contains the source code of an iPod unlocker app made with Windows Forms and C# back in circa 2009.

As I was not using Git at the time, there is unfortunately no commit history. The code in this repository directly mirrors the latest state of the code in the original project, with the exception of this README file and the LICENSE file.

## What do you mean "iPod unlocker"?
Older versions of the iPods with the click wheel have a very insecure way of "locking" the device. The lock is simply a file named `_locked` located on the iPod's filesystem. Sometimes, iPod locks failed because the file was not created properly, or was corrupted. All this app does is delete the file, and the iPod is unlocked.

## How to build
This project was built with Visual Studio 2008, .NET Framework 3.5. To build it, open the solution file `iPodUnlocker.sln` in Visual Studio 2008 or later, and build the solution. The output will be in the `bin` folder.

## Contributions
I am not currently, nor will I ever, accept any contributions to this project. This repository is simply for archiving purposes, and for personal reference. Feel free to fork this repository if you so wish, but I will not be maintaining it.

## License
This project is licensed under the MIT License. See the [`LICENSE.md`](LICENSE.md) file for details.