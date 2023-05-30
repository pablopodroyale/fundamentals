namespace Challenges.Beginner.MiddleNode
{
    public class MiddleNode
    {
        public ListNode MiddleNodeSolution(ListNode head)
        {
            List<ListNode> listAux = new List<ListNode>();
            ListNode nodeAux = head;
            do
            {
                listAux.Add(nodeAux);
                nodeAux = nodeAux.next;
            } while (nodeAux != null);

            return listAux[(int)(listAux.Count() / 2)];
        }
    }
}
