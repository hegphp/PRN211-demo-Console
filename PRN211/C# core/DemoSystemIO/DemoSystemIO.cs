namespace DemoSystemIO {
    internal class DemoDriveInfo {
        public static void ShowAllDrive() {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives) {
                Console.WriteLine($"{drive.Name}, Format: {drive.DriveFormat}, Volumn: {drive.TotalSize}, Free: {drive.TotalFreeSpace}");
            }
        }
    }
}