// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Applications.Containers.Models
{
    /// <summary> Container App Private Registry. </summary>
    public partial class RegistryCredentials
    {
        /// <summary> Initializes a new instance of RegistryCredentials. </summary>
        public RegistryCredentials()
        {
        }

        /// <summary> Initializes a new instance of RegistryCredentials. </summary>
        /// <param name="server"> Container Registry Server. </param>
        /// <param name="username"> Container Registry Username. </param>
        /// <param name="passwordSecretRef"> The name of the Secret that contains the registry login password. </param>
        /// <param name="identity"> A Managed Identity to use to authenticate with Azure Container Registry. For user-assigned identities, use the full user-assigned identity Resource ID. For system-assigned identities, use &apos;system&apos;. </param>
        internal RegistryCredentials(string server, string username, string passwordSecretRef, string identity)
        {
            Server = server;
            Username = username;
            PasswordSecretRef = passwordSecretRef;
            Identity = identity;
        }

        /// <summary> Container Registry Server. </summary>
        public string Server { get; set; }
        /// <summary> Container Registry Username. </summary>
        public string Username { get; set; }
        /// <summary> The name of the Secret that contains the registry login password. </summary>
        public string PasswordSecretRef { get; set; }
        /// <summary> A Managed Identity to use to authenticate with Azure Container Registry. For user-assigned identities, use the full user-assigned identity Resource ID. For system-assigned identities, use &apos;system&apos;. </summary>
        public string Identity { get; set; }
    }
}
