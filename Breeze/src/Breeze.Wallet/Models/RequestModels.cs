﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Breeze.Wallet.Models
{
    /// <summary>
    /// Object used to create a new wallet
    /// </summary>
    public class WalletCreationRequest
    {
        [Required(ErrorMessage = "A password is required.")]
        public string Password { get; set; }

        public string Network { get; set; }

        public string FolderPath { get; set; }

        [Required(ErrorMessage = "The name of the wallet to create is missing.")]
        public string Name { get; set; }
    }

    public class WalletLoadRequest
    {
        [Required(ErrorMessage = "A password is required.")]
        public string Password { get; set; }

        public string FolderPath { get; set; }

        [Required(ErrorMessage = "The name of the wallet is missing.")]
        public string Name { get; set; }
    }

    public class WalletRecoveryRequest
    {
        [Required(ErrorMessage = "A mnemonic is required.")]
        public string Mnemonic { get; set; }

        [Required(ErrorMessage = "A password is required.")]
        public string Password { get; set; }

        public string FolderPath { get; set; }

        [Required(ErrorMessage = "The name of the wallet is missing.")]
        public string Name { get; set; }

        public string Network { get; set; }
    }

    public class WalletHistoryRequest
    {
        [Required(ErrorMessage = "The name of the wallet is missing.")]
        public string WalletName { get; set; }

        [Required(ErrorMessage = "The type of coin for which history is requested is missing.")]
        public CoinType CoinType { get; set; }
    }

    public class WalletName
    {
        [Required(ErrorMessage = "The name of the wallet is missing.")]
        public string Name { get; set; }
    }

    public class BuildTransactionRequest
    {
        [Required(ErrorMessage = "A password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "A destination address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "An amount is required.")]
        public string Amount { get; set; }

        [Required(ErrorMessage = "A fee type is required. It can be 'low', 'medium' or 'high'.")]
        public string FeeType { get; set; }

        public bool AllowUnconfirmed { get; set; }
    }

    public class SendTransactionRequest
    {
        [Required(ErrorMessage = "A transaction in hexadecimal format is required.")]
        public string Hex { get; set; }
    }

}
