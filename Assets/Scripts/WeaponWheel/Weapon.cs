using System.Collections;
using UnityEngine;

namespace WeaponWheel
{
    public class Weapon : MonoBehaviour
    {
        public int Index;
        public string Name;
        public int Clips;
        public int ClipSize;
        public int ammo;
        public GameObject player, fpscontroller;
        public bool noammo = false;

        public int Ammo => ammo;
        public int AmmoInUse => ammoInUse;

        public int ammoInUse;
        public bool _isReloading = false;
        
        public Weapon(int index = 0, string name = "Pistol", int clips = 5, int clipSize = 30)
        {
            Index = index;
            Name = name;
            Clips = clips;
            ClipSize = clipSize;
        }

        private void Start()
        {
            noammo = false;
            ammo = ClipSize;
            ammoInUse = ClipSize; //The ammo in our current clip
        }

    
        public void Shoot()
        {
            if(ammo + ammoInUse <= 0)
                return;
            
            if (ammoInUse > 0)
            {
                noammo = false;
                ammoInUse--;
            }
            if (ammoInUse<1)
            {
                noammo = true;
                ClipSize = 0;
                ammo = 0;
               // StartCoroutine(Reload());
            }
        }

        public bool exec = false;
        public IEnumerator Reload()
        {
            //We need to reload!
            //Change the Clip Only Once
            if (!exec)
            {
                ammo -= ClipSize;
                Clips--;
                exec = true;
            }
            _isReloading = true;
            yield return new WaitForSeconds(1f);
            ammoInUse = ClipSize;
            exec = false;
            _isReloading = false;
        }
    
        private void Update()
        {

            if (name == "Şırınga")
            {
                ClipSize = fpscontroller.GetComponent<InventoryController>().kapsul;
                ammo = fpscontroller.GetComponent<InventoryController>().kapsul;
                
            }

            else if (name == "İlaç")
            {
                ClipSize = fpscontroller.GetComponent<InventoryController>().ilac;
                ammo = fpscontroller.GetComponent<InventoryController>().ilac;
            }

            else if (name == "Liquid")
            {
                ClipSize = fpscontroller.GetComponent<InventoryController>().borel;
                ammo = fpscontroller.GetComponent<InventoryController>().borel;
            }

            else if (name == "Steam")
            {
                ClipSize = fpscontroller.GetComponent<InventoryController>().steam;
                ammo = fpscontroller.GetComponent<InventoryController>().steam;
            }            
            
            else if (name == "Maske")
            {
                ClipSize = fpscontroller.GetComponent<InventoryController>().maske;
                ammo = fpscontroller.GetComponent<InventoryController>().maske;
            }     
            
            else if (name == "Kolonya")
            {
                ClipSize = fpscontroller.GetComponent<InventoryController>().kolonya;
                ammo = fpscontroller.GetComponent<InventoryController>().kolonya;
            }            
            
            else if (name == "Scw")
            {
                ClipSize = fpscontroller.GetComponent<InventoryController>().sicvepis;
                ammo = fpscontroller.GetComponent<InventoryController>().sicvepis;
            }  
            
            else if (name == "Kellepaca")
            {
                ClipSize = fpscontroller.GetComponent<InventoryController>().kellepaca;
                ammo = fpscontroller.GetComponent<InventoryController>().kellepaca;
            }

            if (ammoInUse > 0)
            {
                noammo = false;
            }

            if (ammoInUse < 1)
            {
                noammo = true;
                ClipSize = 0;
                ammo = 0;
            }

            /*    if (ammoInUse <= 0 && ammo > 0)
                {
                    //Reload Automatically
                    StartCoroutine(Reload());
                }

            */
        }
    }
}