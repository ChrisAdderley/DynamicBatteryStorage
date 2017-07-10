using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace DynamicBatteryStorage
{
  // This enum consists of all handled types. They MUST match the module name
  public enum PowerHandlerType {
    // Stock
    ModuleDeployableSolarPanel,
    ModuleGenerator,
    ModuleResourceConverter,
    ModuleActiveRadiator,
    ModuleResourceHarvester,

    // NFT
    ModuleCurvedSolarPanel,
    FissionGenerator,
    ModuleRadioisotopeGenerator,
    ModuleCryoTank,
    ModuleAntimatterTank,

    // RealBattery
    RealBattery
  }
}
