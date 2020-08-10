# SourceOnlyNugetTest
A small test repository to play with source only nuget packages

I'm generating a "Source Only NuGet Package" as described here:
https://medium.com/@attilah/source-code-only-nuget-packages-8f34a8fb4738

Now we have the Strings.resx file included in the NuGet Package, but it seems to be ignored by the referencing project, no ressources are compiled into the assembly.

The ConsoleApp1 fails with MissingManifestResourceException.

It seems to be hard to find documentation about this. :-(
