# Development

The current development process is discribed in this file.

## Build environment

With every commit and pull request the current version of this library will be build by [travis](https://travis-ci.org/DoBi/charts.net).

## Dependencies

Currently this library needs the [`CoreCompat.System.Drawing`](https://www.nuget.org/packages/CoreCompat.System.Drawing/) 
because DotNet Core currently does not have critical parts of the `System.Drawing` namespace.