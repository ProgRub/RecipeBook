namespace Services.Commands
{
	public interface ICommand
	{
		void Execute();
		void Undo();
		void Redo();
	}
}