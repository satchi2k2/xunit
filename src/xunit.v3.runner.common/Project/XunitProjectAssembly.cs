﻿using System;

namespace Xunit
{
    /// <summary>
    /// Represents an assembly in an <see cref="XunitProject"/>.
    /// </summary>
    public class XunitProjectAssembly
    {
        TestAssemblyConfiguration configuration;

        /// <summary>
        /// Gets or sets the assembly filename.
        /// </summary>
        public string AssemblyFilename { get; set; }

        /// <summary>
        /// Gets or sets the config filename.
        /// </summary>
        public string ConfigFilename { get; set; }

        /// <summary>
        /// Gets the configuration values read from the test assembly configuration file.
        /// </summary>
        public TestAssemblyConfiguration Configuration
        {
            get
            {
                if (configuration == null)
                    configuration = ConfigReader.Load(AssemblyFilename, ConfigFilename);

                return configuration;
            }
        }
    }
}
