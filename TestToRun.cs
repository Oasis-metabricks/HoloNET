
namespace NextGenSoftware.Holochain.HoloNET.Client.TestHarness
{
    /// <summary>
    /// View the README https://github.com/holochain-open-dev/holochain-client-csharp/tree/main/NextGenSoftware.Holochain.HoloNET.Client.TestHarness for details on what each test each...
    /// </summary>
    public enum TestToRun
    {
        TestHarnessGuide, // Show available test harnesses and dashboards
        SimpleTest, // New simple test that doesn't require conductor
        EnhancedDemo, // Interactive demo showing HoloNET in action
        WhoAmI,
        Numbers,
        Signal,
        SaveLoadOASISEntryWithTypeOfEntryDataObject,
        SaveLoadOASISEntryWithEntryDataObject,
        SaveLoadOASISEntryUsingSingleHoloNETAuditEntryBaseClass,
        SaveLoadOASISEntryUsingMultipleHoloNETAuditEntryBaseClasses,
        LoadTestNumbers,
        LoadTestSaveLoadOASISEntry,
        AdminAuthorizeSigningCredentials,
        AdminGenerateAgentPubKey,
        AdminInstallApp,
        AdminEnableApp,
        AdminDisableApp,
        AdminAttachAppInterface,
        AdminRegisterDna,
        AdminListApps,
        AdminListDnas,
        AdminListCellIds,
        AdminListInterfaces,
        AdminDumpFullState,
        AdminDumpState,
        AdminGetDnaDefinition,
        AdminUpdateCoordinators,
        AdminGetAgentInfo,
        AdminAddAgentInfo,
        AdminDeleteCloneCell,
        AdminGetStorageInfo,
        AdminDumpNetworkStats
    }
}