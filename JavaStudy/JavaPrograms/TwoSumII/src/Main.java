public class Main {
    public static void main(String[] args) {
        int[] arr = {2,3,4};
        int target = 6;

        int[] result = new int[2];
        result = TwoSumII(arr, target);
        System.out.print("The TwoSumII indices are ");
        for (int r : result) {
            System.out.format(r + " " );
        }

    }

    private static int[] TwoSumII(int[] arr, int target) {
        if(arr == null || arr.length == 0)
            return new int[]{};

        int l = 0;
        int r = arr.length - 1;

        while(l < r)
        {
            if(arr[l] + arr[r] == target)
            {
                return new int[]{l+1,r+1};
            }
            else if(arr[l] + arr[r] > target)
            {
                r--;
            }
            else
            {
                l++;
            }
        }

        return new int[]{};
    }
}