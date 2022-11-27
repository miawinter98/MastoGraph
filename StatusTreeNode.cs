using Mastonet.Entities;

namespace MastoGraph; 

public class StatusTreeNode {
	public Status Status { get; }
	public bool IsRoot { get; init; } = false;

	public List<StatusTreeNode> Children { get; } = new();
	
	public StatusTreeNode(Status status) {
		Status = status;
	}

	public bool AddNode(StatusTreeNode node) {
		if (Status.Id == node.Status.InReplyToId) {
			Children.Add(node);
			return true;
		}

		return Children.Any(child => child.AddNode(node));
	}
}