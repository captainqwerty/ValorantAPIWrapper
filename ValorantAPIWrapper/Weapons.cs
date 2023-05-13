using Newtonsoft.Json;
using ValorantAPIWrapper.Models;

namespace ValorantAPIWrapper
{
    // https://dash.valorant-api.com/endpoints/weapons
    public class Weapons
    {
        /// <summary>
        /// Retrieves a list of all weapons in Valorant from the Valorant API.
        /// </summary>
        /// <returns>A list of WeaponModel objects representing each weapon in Valorant.</returns>
        public async static Task<List<WeaponModel>> GetAllWeapons()
        {
            List<WeaponModel> weapons;

            using (var httpClient = new HttpClient())
            {
                var uri = new Uri("https://valorant-api.com/v1/weapons");
                var response = await httpClient.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();
                WeaponResponse weaponResponse = JsonConvert.DeserializeObject<WeaponResponse>(json);
                weapons = weaponResponse.Data;
            }

            return weapons;
        }

        /// <summary>
        /// Retrieves a weapon in Valorant with the specified name.
        /// </summary>
        /// <param name="WeaponName">The name of the weapon to retrieve.</param>
        /// <returns>A WeaponModel object representing the weapon with the specified name, or null if no weapon is found.</returns>
        public async static Task<WeaponModel> GetWeaponByName(string WeaponName)
        {
            var weapons = await GetAllWeapons();
            var weapon = weapons.Where(a => a.displayName.Equals(WeaponName.Trim(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            return weapon;
        }
    }
}