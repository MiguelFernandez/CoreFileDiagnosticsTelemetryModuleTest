
using System;
using System.Reflection;

namespace testingAICore
{
    internal class ApplicationNameProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationNameProvider"/> class.
        /// </summary>
        public ApplicationNameProvider()
        {
            this.Name = GetApplicationName();
        }

        /// <summary>
        /// Gets name of the current assembly.
        /// </summary>
        public string Name { get; private set; }

        private static string GetApplicationName()
        {
            try
            {
                return Assembly.GetEntryAssembly().GetName().Name;
            }
            catch (Exception exp)
            {
                return "Undefined " + exp.Message;
            }
        }
    }
}
