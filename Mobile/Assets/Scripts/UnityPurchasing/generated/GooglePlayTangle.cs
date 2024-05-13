// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("WSmSVCvpfdGcM2auZ/67n4U0vBL1LBj3kGryG8SFuqLd0xGaoYP38IQ2tZaEubK9njL8MkO5tbW1sbS3MmKDth1tVqZV7zCQHGnh7FQluF8oLGb2yDB9ar2C0kJ2qQ9i3qlalFSGY9nbXea3wmnMT06eWh4jCprLfmYaQbHNN9LmdmPqCBjBT0y3T1g+3O/AwayZIjeCynyk7tSPmqqDSza1u7SENrW+tja1tbQgBdgUkpMCUEBkz+6TOdHdQ02Nei6cE6GRwPT8kVi9U+ZV+mYvlEYEumRfeIqy3DTPQ6c5WmnHSt/5GX3s6m9dirh+iD3SVPhBNu9WDt+pIyv+nmshFYGb35QTn4nQaH22wvnPENAipH4xqCxJIT9BjVmWX7a3tbS1");
        private static int[] order = new int[] { 5,4,5,8,5,6,7,11,11,9,11,11,12,13,14 };
        private static int key = 180;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
