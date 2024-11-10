
public class BinaryTree {
    public static Node insert(Node? node, string value) {
        if(node == null) return new Node(value);

        if (String.Compare(value, node.value) < 0) {
            node.left = insert(node.left, value);
        } else {
            node.right = insert(node.right, value);
        }
        return node;
    }

    public static void PrintPreOrder(Node? node) {
        if(node == null) return;

        Console.Write(node.value + " ");
        PrintPreOrder(node.left);
        PrintPreOrder(node.right);
    }

    public static void PrintInOrder(Node? node) {
        if(node == null) return;

        PrintInOrder(node.left);
        Console.Write(node.value + " ");
        PrintInOrder(node.right);
        
    }

    public static void PrintPostOrder(Node? node) {
        if(node == null) return;

        PrintPostOrder(node.left);
        PrintPostOrder(node.right);
        Console.Write(node.value + " ");
    }

    public static bool IsStrictBinaryTree(Node? node) {
        if(node == null) return true;

        if(
            (node.left == null && node.right != null)
            || (node.left != null && node.right == null)
        ) return false;

        return IsStrictBinaryTree(node.left) && IsStrictBinaryTree(node.right);
    }

    public static int Depth(Node? node) {
        if(node == null) return 0;

        return Math.Max(
            Depth(node.left),
            Depth(node.right)
        ) + 1;
    }

    public static void PrettyPrint(Node? node) {
        if (node == null) return;
        int depth = Depth(node);
        int col = GetCol(depth);

        string[][] M = new string[depth][];

        for (int i = 0; i < depth; i++) {
            M[i] = new string[col];
            Array.Fill(M[i], "");
        }

        PrintTree(M, node, col / 2, 0, depth);

        for (int i = 0; i < M.Length; i++) {
            string row = "";
            for (int j = 0; j < M[i].Length; j++) {
                if (String.IsNullOrEmpty(M[i][j])) {
                    row += " ";
                } else {
                    row += M[i][j] + " ";
                }
            }
            Console.WriteLine(row);
        }

    }

    static int GetCol(int h) {
        if (h == 1) {
            return 1;
        }
        return GetCol(h - 1) + GetCol(h - 1) + 1;
    }

    static void PrintTree(string[][] M, Node? root, int col, int row, int depth) {
        if (root == null) return;

        M[row][col] = root.value;
        PrintTree(M, root.left, col - (int)Math.Pow(2, depth - 2), row + 1, depth - 1);
        PrintTree(M, root.right, col + (int)Math.Pow(2, depth - 2), row + 1, depth - 1);
    }

}