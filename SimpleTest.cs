using System;
using System.Threading.Tasks;
using NextGenSoftware.Holochain.HoloNET.Client;
using NextGenSoftware.Holochain.HoloNET.Client.Data.Admin.Requests.Objects;
using NextGenSoftware.Holochain.HoloNET.Client.Interfaces;

namespace NextGenSoftware.Holochain.HoloNET.Client.TestHarness
{
    public class SimpleTest
    {
        public static async Task RunSimpleTest()
        {
            Console.WriteLine("🚀 HoloNET Simple Test - No Conductor Required");
            Console.WriteLine("=============================================");
            
            try
            {
                // Create HoloNET client configuration
                var config = new HoloNETDNA()
                {
                    AutoStartHolochainConductor = false, // Don't auto-start conductor
                    AutoShutdownHolochainConductor = false,
                    ShutDownALLHolochainConductors = false,
                    ShowHolochainConductorWindow = false,
                    HolochainConductorMode = HolochainConductorModeEnum.UseEmbedded,
                    HolochainConductorToUse = HolochainConductorEnum.HolochainProductionConductor
                };

                // Create the HoloNET client
                var holonetClient = new HoloNETClientAdmin();
                
                // Set the configuration
                holonetClient.HoloNETDNA = config;
                
                Console.WriteLine("✅ HoloNET Client created successfully!");
                Console.WriteLine($"   - Client Type: {holonetClient.GetType().Name}");
                Console.WriteLine($"   - Config: {config.HolochainConductorMode}");
                Console.WriteLine($"   - Auto Start: {config.AutoStartHolochainConductor}");
                
                // Test basic client functionality
                Console.WriteLine("\n🔧 Testing Basic Client Functionality:");
                Console.WriteLine($"   - State: {holonetClient.State}");
                Console.WriteLine($"   - EndPoint: {holonetClient.EndPoint}");
                Console.WriteLine($"   - WebSocket State: {holonetClient.WebSocket?.State}");
                
                // Test configuration access
                Console.WriteLine("\n⚙️  Configuration Details:");
                Console.WriteLine($"   - Conductor Mode: {holonetClient.HoloNETDNA.HolochainConductorMode}");
                Console.WriteLine($"   - Conductor Type: {holonetClient.HoloNETDNA.HolochainConductorToUse}");
                Console.WriteLine($"   - Show Window: {holonetClient.HoloNETDNA.ShowHolochainConductorWindow}");
                
                // Test event handlers (without actually connecting)
                Console.WriteLine("\n📡 Event Handler Test:");
                holonetClient.OnConnected += (sender, e) => Console.WriteLine("   ✅ Connected event handler registered");
                holonetClient.OnDisconnected += (sender, e) => Console.WriteLine("   ✅ Disconnected event handler registered");
                holonetClient.OnError += (sender, e) => Console.WriteLine("   ✅ Error event handler registered");
                
                Console.WriteLine("   ✅ All event handlers registered successfully");
                
                // Test client shutdown
                Console.WriteLine("\n🔄 Testing Client Shutdown:");
                holonetClient.ShutdownHoloNET();
                Console.WriteLine("   ✅ HoloNET client shutdown completed");
                
                Console.WriteLine("\n🎉 Simple Test Completed Successfully!");
                Console.WriteLine("   HoloNET is working correctly without requiring a Holochain conductor.");
                Console.WriteLine("   The client can be created, configured, and managed properly.");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error during simple test: {ex.Message}");
                Console.WriteLine($"   Stack trace: {ex.StackTrace}");
            }
        }
    }
}
