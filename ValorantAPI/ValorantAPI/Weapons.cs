using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorantAPI.Models;
using static ValorantAPI.Models.WeaponModel;

namespace ValorantAPI
{
    public class Weapons
    {
        public static List<WeaponModel> GetAllWeapons()
        {
            List<WeaponModel> weapons;

            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("https://valorant-api.com/v1/maps");
                WeaponResponse response = JsonConvert.DeserializeObject<WeaponResponse>(json);
                weapons = response.Data;
            }

            return weapons;
        }

        public static WeaponModel GetWeaponByName(string WeaponName)
        {
            var weapons = GetAllWeapons();
            var weapon = weapons.Where(a => a.displayName.Equals(WeaponName.Trim(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            return weapon;
        }
    }
}
