using System;


namespace R5T.Tools.Dotnet
{
    /// <summary>
    /// The project-types recognized by the dotnet new command.
    /// </summary>
    public enum DotnetNewProjectType
    {
        Library = 0,
        Console,
        MSTest,
    }
}
