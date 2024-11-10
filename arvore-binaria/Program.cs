Node? root = null;

foreach(var value in new string[] {"E", "B", "A", "G", "H", "I", "F", "D", "C"}) {
    root = BinaryTree.insert(root, value);
}
BinaryTree.PrettyPrint(root);
Console.WriteLine();

Console.Write("In Order: ");
BinaryTree.PrintInOrder(root);
Console.WriteLine();
Console.Write("Post Order: ");
BinaryTree.PrintPostOrder(root);
Console.WriteLine();
Console.Write("Pre Order: ");
BinaryTree.PrintPreOrder(root);
Console.WriteLine();

Console.WriteLine($"Is strict binary tree: {(BinaryTree.IsStrictBinaryTree(root) ? "yes" : "no")}");

