namespace prove_04;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add the following Queue: Peter 4, Jon 2, Ethan 1
        // Expected Result: [Peter (Pri:4), Jon (Pri:2), Ethan (Pri:1)
        Console.WriteLine("Test 1");

        var test1Queue = new PriorityQueue();
        test1Queue.Enqueue("Peter",4);
        test1Queue.Enqueue("Jon",2);
        test1Queue.Enqueue("Ethan",1);

        Console.WriteLine(test1Queue.ToString());

        if (test1Queue.ToString() == "[Peter (Pri:4), Jon (Pri:2), Ethan (Pri:1)]")
        {
            Console.WriteLine("Test 1 Passed");
        }
        else
        {
            Console.WriteLine("Test 1 Failed");
        }

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: Remove Jon
        Console.WriteLine("Test 2");

        var test2Queue = new PriorityQueue();
        test2Queue.Enqueue("Peter", 4);
        test2Queue.Enqueue("Jon", 6);
        test2Queue.Enqueue("Ethan", 5);

        var removedItem = test2Queue.Dequeue();

        Console.WriteLine("Person Removed was " + removedItem);
        Console.WriteLine(test2Queue.ToString());

        if (removedItem == "Jon")
        {
            Console.WriteLine("Test 2 Passed");
        }
        else
        {
            Console.WriteLine("Test 2 failed.");
        }

        // Defect(s) Found: It says that Jon is removed but still is shown.

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}