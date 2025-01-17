﻿using GameServer.Networking;
using GameServer.Properties;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GameServer
{

    internal static class Program
    {

        [STAThread]
        private static void Main()
        {
            var ush = BitConverter.ToInt16(new byte[] { 161, 5 }, 0);
            var test = BitConverter.ToInt32(new byte[] { 25, 75, 0, 0 }, 0);
            var server = new byte[] { 153, 186, 88, 131, 47, 227, 182, 210, 34, 152, 151, 221, 52, 57, 252, 68, 75, 70, 157, 172, 1, 239, 94, 0, 235, 168, 116, 55, 0, 125, 20, 60, 132, 230, 85, 90, 161, 103, 215, 227, 115, 22, 12, 62, 211, 148, 155, 3, 66, 64, 82, 202, 114, 223, 185, 71, 1, 63, 33, 124, 146, 64, 87, 135, 173, 117, 185, 69, 167, 240, 185, 228, 191, 31, 117, 139, 235, 96, 7, 129, 143, 28, 154, 246, 169, 122, 32, 245, 237, 210, 244, 144, 236, 71, 232, 200, 21, 80, 216, 119, 185, 26, 39, 59, 207, 147, 114, 174, 181, 231, 117, 27, 44, 68, 158, 75, 58, 122, 54, 240, 120, 113, 251, 192, 240, 106, 81, 241, 247, 186, 208, 130, 23, 155, 221, 236, 103, 58, 212, 162, 241, 120, 100, 92, 55, 187, 217, 206, 119, 168, 68, 34, 19, 153, 205, 110, 118, 179, 157, 234, 81, 136, 68, 38, 67, 48, 39, 14, 102, 58, 212, 162, 22, 137, 76, 102, 116, 122, 72, 46, 133, 158, 36, 31, 19, 153, 205, 110, 116, 179, 157, 234, 135, 56, 199, 57, 235, 102, 100, 15, 102, 58, 212, 162, 49, 1, 205, 151, 54, 187, 217, 206, 114, 168, 68, 34, 28, 231, 61, 236, 246, 178, 167, 208, 81, 136, 68, 38, 49, 155, 221, 236, 36, 36, 33, 14, 17, 137, 76, 102, 55, 187, 217, 206, 85, 228, 179, 198, 18, 153, 205, 110, 113, 179, 157, 234, 135, 56, 199, 57, 35, 9, 238, 214, 103, 58, 212, 162, 19, 137, 76, 102, 246, 177, 137, 73, 117, 168, 68, 34, 19, 153, 205, 110, 230, 141, 23, 15, 80, 136, 68, 38, 52, 155, 221, 236, 36, 36, 33, 14, 1, 41, 87, 92, 55, 187, 217, 206, 119, 168, 68, 34, 28, 231, 61, 236, 118, 179, 157, 234, 81, 136, 68, 38, 99, 101, 160, 8, 102, 58, 212, 162, 22, 137, 76, 102, 246, 177, 137, 73, 101, 6, 71, 24, 19, 153, 205, 110, 116, 179, 157, 234, 135, 56, 199, 57, 51, 155, 221, 236, 103, 58, 212, 162, 33, 47, 77, 106, 54, 187, 217, 206, 114, 168, 68, 34, 28, 231, 61, 236, 22, 110, 251, 212, 81, 136, 68, 38, 49, 155, 221, 236 };
            var client = new byte[] { 63, 208, 180, 185, 200, 76, 146, 134, 139, 127, 188, 55, 140, 249, 253, 73, 38, 46, 216, 133, 17, 74, 161, 34, 29, 106, 65, 48, 67, 200, 20, 163, 28, 228, 61, 185, 28, 140, 13, 219, 25, 152, 65, 50, 109, 244, 180, 98, 19, 152, 198, 91, 19, 134, 242, 61, 29, 106, 65, 28, 67, 200, 20, 163, 28, 228, 61, 185, 28, 140, 13, 219, 25, 152, 65, 50, 98, 244, 180, 98, 19, 153, 207, 98, 17, 142, 115, 152, 193, 8, 68, 38, 51, 152, 196, 35, 28, 230, 48, 130, 17, 137, 76, 102, 49, 136, 71, 57, 204, 96, 4, 34, 19, 153, 204, 98, 17, 142, 115, 152, 193, 8, 68, 38, 51, 152, 196, 35, 28, 230, 48, 130, 17, 137, 76, 102, 49, 136, 71, 57, 204, 96, 4, 34, 19, 153, 204, 98, 17, 142, 115, 152, 193, 8, 68, 38, 51, 152, 196, 35, 28, 230, 48, 130, 17, 137, 76, 102, 49, 136, 71, 57, 204, 96, 4, 34, 19, 153, 204, 98, 17, 142, 115, 152, 193, 8, 68, 38, 165, 57, 206, 119, 108, 100, 39, 57, 197, 131, 94, 147, 59, 136, 71, 57, 117, 44, 180, 126, 155, 145, 239, 62, 73, 126, 179, 152, 192, 1, 101, 46, 60, 219, 228, 139, 12, 233, 15, 143, 129, 73, 76, 102, 50, 139, 99, 117, 202, 135, 1, 62, 147, 144, 239, 60, 13, 126, 179, 152, 195, 1, 228, 42, 115, 226, 200, 120, 1, 233, 112, 128, 128, 156, 172, 249, 51, 123, 99, 165, 149, 190, 225, 205, 158, 144, 144, 59, 40, 171, 83, 7, 193, 244, 200, 166, 63, 231, 29, 121, 1, 233, 112, 128, 128, 156, 172, 249, 51, 123, 99, 165, 149, 190, 225, 205, 158, 144, 144, 60, 12, 171, 83, 7, 195, 241, 228, 42, 115, 226, 200, 120, 1, 233, 112, 128, 128, 156, 172, 249, 51, 123, 99, 165, 149, 190, 225, 205, 158, 144, 144, 50, 4, 171, 83, 7, 193, 252, 32, 245, 74, 136, 236, 71, 57, 62, 238, 3, 194, 209, 241, 154, 255, 249, 38, 108, 197, 164, 5, 114, 146, 127, 26, 30, 27, 225, 31, 40, 131, 116, 160, 253, 126, 40, 169, 119, 152, 58, 4, 162, 2, 17, 117, 169 };
            var key = new byte[server.Length];

            for (var i = 0; i < server.Length; i++)
            {
                key[i] = (byte)(server[i] ^ client[i]);
            }

            using var myMutex = new Mutex(false, "LOMCN_GameServer_Mutex", out bool flag);

            if (flag)
            {
                Application.EnableVisualStyles();
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.SetCompatibleTextRenderingDefault(false);

                Config.SendPacketsAsync = Settings.Default.SendPacketsAsync;
                Config.DebugPackets = Settings.Default.DebugPackets;
                GamePacket.Config(typeof(SConnection));

                Application.Run(new MainForm());
                return;
            }

            MessageBox.Show("The server is already up and running");
            Environment.Exit(0);
        }
    }
}
