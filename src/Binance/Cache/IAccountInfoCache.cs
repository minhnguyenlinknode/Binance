﻿using System;
using Binance.Account;
using Binance.Api;
using Binance.Cache.Events;
using Binance.Client;

namespace Binance.Cache
{
    public interface IAccountInfoCache : IJsonClientCache<IUserDataClient, AccountInfoCacheEventArgs>
    {
        /// <summary>
        /// The account information. Can be null if not yet synchronized or out-of-sync.
        /// </summary>
        AccountInfo AccountInfo { get; }

        /// <summary>
        /// Subscribe to a user.
        /// </summary>
        /// <param name="listenKey">The listen key to subscribe.</param>
        /// <param name="symbol">The user.</param>
        /// <param name="callback">The callback (optional).</param>
        void Subscribe(string listenKey, IBinanceApiUser user, Action<AccountInfoCacheEventArgs> callback);
    }
}
