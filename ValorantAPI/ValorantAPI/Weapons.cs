using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using ValorantAPI.Models;

namespace ValorantAPI
{
    //https://dash.valorant-api.com/endpoints/weapons
    public class Weapons
    {
        /// <summary>
        /// Retrieves a list of all weapons in Valorant from the Valorant API.
        /// </summary>
        /// <returns>A list of WeaponModel objects representing each weapon in Valorant.</returns>
        public static List<WeaponModel> GetAllWeapons()
        {
            List<WeaponModel> weapons;

            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("https://valorant-api.com/v1/weapons");
                WeaponResponse response = JsonConvert.DeserializeObject<WeaponResponse>(json);
                weapons = response.Data;
            }

            return weapons;
        }

        /// <summary>
        /// Retrieves a weapon in Valorant with the specified name.
        /// </summary>
        /// <param name="WeaponName">The name of the weapon to retrieve.</param>
        /// <returns>A WeaponModel object representing the weapon with the specified name, or null if no weapon is found.</returns>
        public static WeaponModel GetWeaponByName(string WeaponName)
        {
            return GetAllWeapons().Where(a => a.displayName.Equals(WeaponName.Trim(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }
    }
}
