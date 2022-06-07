import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        int[] arr = {-1,0,1,2,-1,4};
        List<int[]> result; //= new ArrayList<ArrayList<Integer>>();
        result = ThreeSum(arr);
        for (var item :
                result) {
            for (var num :
                 item) {
                System.out.print(num + " ");
            }
            System.out.println();
        }
    }

    private static List<int[]> ThreeSum(int[] arr) {
        if(arr == null || arr.length == 0)
            return new ArrayList<>();

        List<int[]> res = new ArrayList<>();
        Arrays.sort(arr);
        for (int i = 0; i < arr.length; i++) {
            int a = arr[i];
            if(i > 0 && arr[i] == arr[i - 1])
                continue;
            int l = i + 1;
            int r = arr.length - 1;
            while(l < r)
            {
                int threeSum = a + arr[l] + arr[r];
                if(threeSum == 0)
                {
                    res.add(new int[]{a,arr[l],arr[r]});
                    while(l < arr.length && arr[l] == arr[l+1])
                    {
                        l++;
                    }
                    l++;
                }
                else if(threeSum > 0)
                {
                    r--;
                }
                else if(threeSum < 0)
                {
                    l++;
                }
            }
        }
        return res;
    }
}