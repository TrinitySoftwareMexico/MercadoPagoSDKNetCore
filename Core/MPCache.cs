using Cache;
using System;

namespace MercadoPago
{
    /// <summary>
    /// Class for managing cached resources.
    /// </summary>
    public class MPCache
    {
        /// <summary>
        /// Adds a response to the cache structure.
        /// </summary>
        /// <param name="key">Key representing the URL.</param>
        /// <param name="response">Response representing the response of the given URL parameter.</param>
        public static void AddToCache(string key, MPAPIResponse response) 
        {
            try
            {
                ///HttpRuntime.Cache.Add(key, response, null, DateTime.MaxValue, new TimeSpan(0, 1, 0), System.Web.Caching.CacheItemPriority.Default, null);
                CacheItemDictionary<string, object> cache = new CacheItemDictionary<string, object>();
                cache.Add(key, (object)response);
            }
            catch (Exception ex)
            {
                throw new MPException("An error has occured in the cache structure (ADD): " + ex.Message);
            }
        }

        /// <summary>
        /// Retrieves a cached response from cache structure.
        /// </summary>
        /// <param name="key">Key that will return its associated value.</param>
        /// <returns>Cached response.</returns>
        public static MPAPIResponse GetFromCache(string key)
        {
            object value;
            try
            {
                ///return (MPAPIResponse)HttpRuntime.Cache.Get(key);            
                CacheItemDictionary<string, object> cache = new CacheItemDictionary<string, object>();
                if (cache.TryGetValue(key, out value))
                    return (MPAPIResponse)value;
                else
                    throw new MPException("An error has occured in the cache structure (GET)");
            }
            catch (Exception ex)
            {
                throw new MPException("An error has occured in the cache structure (GET): " + ex.Message);
            }            
        }

        /// <summary>
        /// Remove a specified item from cache.
        /// </summary>
        /// <param name="key">Key of the element to remove from cache.</param>
        public static void RemoveFromCache(string key)
        {
            try
            {
                ///HttpRuntime.Cache.Remove(key);
                CacheItemDictionary<string, object> cache = new CacheItemDictionary<string, object>();
                cache.Remove(key);
            }
            catch (Exception ex)
            {
                throw new MPException("An error has occured in the cache structure (REMOVE): " + ex.Message);
            }            
        }
    }
}
