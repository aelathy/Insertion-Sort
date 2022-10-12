// Insertion Sort
#nullable disable
Console.Clear();

// function insertionSort(anArray) {
//   for (every element starting at the second position to the end) {
//     save the value to insert
//     save the insert position

//     while (there are elements to the left of the insert position and
//           the test element to the left is > value to insert) {
//       slide the test element to the right
//       decrease the insert position
//     }

//     put the value to insert into the insert position
//   }
// }

List<int> mynums = new List<int> { 8, 2, 5, 1, 0, 1, 4, 6, 2, 4, 6 };
List<string> cars = new List<string> { "Ram", "Ford", "Subaru", "Honda", "Hyundai", "Acura" };

int insertionSort(List<int> aList)
{
    for (int i = 1; i < aList.Count; i++)
    {
        int ins_value = aList[i];
        int ins_pos = i - 1;

        while (ins_pos >= 0 && aList[ins_pos] > ins_value)
        {
            aList[ins_pos + 1] = aList[ins_pos];
            ins_pos = ins_pos - 1;
        }
        aList[ins_pos + 1] = ins_value;
    }
    return -1;
}

insertionSort(mynums);
for (int i = 0; i < mynums.Count; i++)
{
    Console.WriteLine(mynums[i]);
}

