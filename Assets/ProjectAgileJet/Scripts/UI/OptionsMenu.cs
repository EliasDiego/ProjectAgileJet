using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using YergoScripts;

namespace ProjectAgileJet.UI
{
    public class OptionsMenu : Menu
    {
        public override void EnableMenu()
        {
            base.EnableMenu();

            transform.SetActiveChildren(true);
        }

        public override void DisableMenu()
        {
            base.DisableMenu();
            
            transform.SetActiveChildren(false);
        }
    }
}