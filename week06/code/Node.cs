public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value == Data)
        {
            return; // Ignore duplicates
        }
        else if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true; // Found the value
        }
        else if (value < Data)
        {
            return Left is not null && Left.Contains(value); // Search left
        }
        else
        {
            return Right is not null && Right.Contains(value); // Search right
        }
    }

    public int GetHeight()
    {
        // Base case: If the node is null, return 0 (this will be handled by parent calls)
        if (this == null) return 0;

        // Recursively get the height of the left and right subtrees
        int leftHeight = Left is not null ? Left.GetHeight() : 0;
        int rightHeight = Right is not null ? Right.GetHeight() : 0;

        // The height of the current node is 1 + the max height of its subtrees
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}