﻿namespace CommandLineWrapper.Abstraction.Interfaces;

/// <summary>
/// Defines a fluent method responsible for setting the name of a <see cref="System.CommandLine.Command"/>.
/// </summary>
public interface ICommandCanSetName : IIdentifierSymbolCanSetName
{
    /// <returns>An <see cref="ICommandCanSetProperties"/> with the given name.</returns>
    /// <inheritdoc cref="IIdentifierSymbolCanSetName.SetName(string)"/>
    new ICommandCanSetProperties SetName(string name);
}
