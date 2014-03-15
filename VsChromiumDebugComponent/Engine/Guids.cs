﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsChromium
{
  public static class Guids
  {
    public static readonly Guid MicrosoftVendorGuid = new Guid("994B45C4-E6E9-11D2-903F-00C04FA302A1");
    public static readonly Guid CppLanguageGuid = new Guid("3A12D0B7-C26C-11D0-B442-00A0244A1DD2");

    public const string guidChromeDebugComponentId = "5D83386D-8A02-475F-8582-E93296A88DF6";
    public static readonly Guid ChromeDebugComponentGuid = new Guid(guidChromeDebugComponentId);

    public const string guidChromeNativeVisualizerId = "5CBA1AEC-0096-4ACE-884E-DC9A0DC57D41";
    public static readonly Guid ChromeNativeVisualizerId = new Guid("5CBA1AEC-0096-4ACE-884E-DC9A0DC57D41");

    public const string guidDateTimeVisualizerId = "6A9197EE-22BD-433A-BF1B-9D8863D87058";
    public static readonly Guid DateTimeVisualizerId = new Guid("6A9197EE-22BD-433A-BF1B-9D8863D87058");

    public const string guidForceDefaultVisualizationId = "8E832A91-B810-4229-BC71-D17B5D5283C6";
    public static readonly Guid ForceDefaultVisualizationGuid = new Guid(guidForceDefaultVisualizationId);
  }
}
