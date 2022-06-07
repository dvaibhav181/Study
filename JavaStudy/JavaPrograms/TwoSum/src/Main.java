import java.util.HashMap;

public class Main {
    public static void main(String[] args)
    {
        int[] arr = new int[]{3,2,4};
        int target = 6;
        TwoSum(arr, target);
    }

    private static void TwoSum(int[] arr, int target) {
        if(arr == null || arr.length == 0)
            return;

        HashMap<Integer, Integer> hashMap = new HashMap<>();
        for (int i = 0; i < arr.length; i++) {
            if(!hashMap.containsKey(target - arr[i]))
            {
                hashMap.put(arr[i],i);
            }
            else
            {
                System.out.format("The TwoSum Indexes are %s and %s",hashMap.get(target - arr[i]),i);
                System.out.println();
            }
        }
    }
}
