public class Node {
    public string value {get;set;}
    public Node? left {get;set;}
    public Node? right {get;set;}

    public Node(string value, Node? left = null, Node? right = null) {
        this.value = value;
        this.left = left;
        this.right = right;
    }

    public bool IsExternal() {
        return left == null && right == null;
    }

    public int Length() {
        int length = 0;

        if (left != null) ++length;
        if (right != null) ++length;

        return length;
    }
}