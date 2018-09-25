# MvXamForms

A simple Xamarin Forms "scractch pad" application incorporating MvvmCross and Xamarin.LiveReload

I needed a simple design / testing scratchpad application. It needed to somewhat mirror my real projects, hence MvvmCross, whilst also being simple enough to quickly morph into whatever I need.

It also makes for a useful real world example of how you might want to structure a cross platform MvvmCross based Xamarin Forms application. Closely following the recommended patterns.

# Projects

| Project Name | Description |
| --- | --- |
| JamSoft.MvXamForms.Core | All UI agnostic logic and view models |
| JamSoft.MvXamForms.Ui | Views and Ui related classes and Custom controls etc. |
| JamSoft.MvXamForms.Ui.Android | Xamarin Forms Android application |
| JamSoft.MvXamForms.Ui.iOS | Xamarin Forms iOS application |

# Referenced Packages

- MvvmCross 6.2.0
- Xamarin Forms 3.1.0.697729
- Xam.Plugin.DeviceInfo 3.1.0
- Android Support 27.0.2.1
- Xamarin.Live.Reload 0.3.27

# Tasks

- [x] Prove Reload works with MvvmCross!
- [ ] Add in some demo services
- [ ] Add in some demo plugins
- [ ] Add in some kind of API integration

# Xamarin.Live.Reload

If you're struggling to find the NuGet package Xamarin.Live.Reload. Open the package manager and make sure you have the package source set to All, not just nuget.org. The extension installs the Xamarin.Live.Reload package into your local package cache. Which is why you can't find it, it's not there!

Critiques and pull requests most welcome :) :+1: