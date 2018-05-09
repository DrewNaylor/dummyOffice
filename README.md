# Welcome to the dummyOffice repo!
As of right now, the only purpose of this repo is hosting my dummyOffice suite. I don't know what to say really in this README file, as this isn't a major project. dummyOffice is mainly for my App Launchers. If you don't have Microsoft Office installed but want to test one of my app launchers ([UXL Launcher](https://github.com/DrewNaylor/UXL-Launcher) &bull; Drew's App Launcher [32-bit](https://github.com/DrewNaylor/MSOfficeAppLauncherNext32), [64-bit](https://github.com/DrewNaylor/MSOfficeAppLauncherNext64)) anyway, you can place dummyOffice files where Microsoft Office would usually place them.

```
dummyOffice - A suite of apps that open a window that says you opened them.
Copyright (C) 2015-2016, 2018 Drew Naylor
Microsoft Office is copyright Microsoft Corp.
Microsoft is not affiliated with either the dummyOffice project or Drew Naylor and does not endorse this software.
(Note that the copyright years include the years left out by the hyphen.)

This file is part of dummyOffice.
(Technically, this is a suite of apps. If you don't have MS Office 
but you want to test my app launcher anyway, you can put these binary files
where MS Office would be.)

dummyOffice is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

dummyOffice is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with dummyOffice.  If not, see <http://www.gnu.org/licenses/>.
```

## PROJECT LICENSE

The license that I am using for this project is the Gnu GPL version 3+, available at <http://www.gnu.org/licenses/gpl.html>

## SOFTWARE REQUIRED TO EDIT

This particular project is a little complicated to edit, but here's what you'll need:

- Obviously, you'll need Git. GitHub has GitHub Desktop and Git Shell for Windows. There is one for Mac as well.
- Microsoft Windows. I developed this using Windows 7 but it should work on Windows XP as I originally used XP to develop it. Windows 8/8.1/10 might work but I haven't tested those yet.
- Microsoft Visual Studio 2010 Professional. Again, it should be possible to use the Express edition, but I haven't used that version to develop this in such a long time. I don't know if Visual Studio 2012+ will work. I want it to be able to support XP for as long as possible because Microsoft Office 2010 supports XP. Maybe I will eventually un-support XP. If I do upgrade from VS2010, I would go to VS2013 as it brought back color on some of the icons.
- Microsoft .Net Framework 4.0 (Included with VS 2010.)

And that's about it as far as software is concerned. 

## How to get Up and Running with the Files in this Repo



- First, clone the repository by running:    `git clone https://github.com/DrewNaylor/dummyOffice.git` and remember where the files are saved.
- Next, open Visual Studio 2010.
- When Visual Studio 2010 launches and is ready for input, click `File>New Project...`.
- In the left sidebar, navigate to `Other Project Types\Visual Studio Solutions` and click on `Blank Solution`. 
- Name your solution something in the `Name:` field, browse for the directory if necessary, and click the `OK` button. As an example, I named mine "dummyOffice" and put it in a folder called "dummyOffice Edits."
- After the Solution file is created, click the `Save All` to save your project.
- Click `File>Add>Existing Project...` and navigate to where you cloned the repo earlier. Open one of the folders there (should be "dummy[Program]") and open up the vbproj file. May take some digging. Repeat until you've added all the project files.
- If all goes well, the projects should appear in the Visual Studio `Solution Explorer`.
 
You'll be using this Solution file you just made to open the project. See the next paragraph for details.

### Why do I need to create a new Solution file? Why can't I just use the original file?

The problem is that Visual Studio is looking for `C:\Users\Drew\...\dummy[App]` and because I (probably) don't share your  computer, I won't have an account on it. By doing this you tell VS to look somewhere else.
