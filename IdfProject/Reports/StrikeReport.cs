using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfProject.Reports
{
    internal class StrikeReport
    {
        string TargetName;
        string AttackCommander;
        string WeaponInUse;
        bool AttackResult;
        int AmmoCapLeft;
        DateTime TimeStamp;
        public StrikeReport(string targetName, string attackCommander, string weaponInUse, bool attackResult, int ammoCapLeft, DateTime timeStamp)
        {
            this.TargetName = targetName;
            this.AttackCommander = attackCommander;
            this.WeaponInUse = weaponInUse;
            this.AttackResult = attackResult;
            this.AmmoCapLeft = ammoCapLeft;
            this.TimeStamp = timeStamp;
        }

        public override string ToString()
        {
            return
                $"TimeStamp: {TimeStamp}\n" +
                $"TargetName: {TargetName}\n" +
                $"attackCommander: {AttackCommander}\n" +
                $"WeaponInUse: {WeaponInUse}\n" +
                $"AttackResult: {AttackResult}\n" +
                $"AmmoCapLeft: {AmmoCapLeft}\n";
        }
    }
}
