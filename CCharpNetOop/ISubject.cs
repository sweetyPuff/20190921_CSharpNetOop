namespace CCharpNetOop
{
	internal interface ISubject
	{
		void Attach(IObserver employee);
		void Notify(string situation);
		void SetStatus(string situation);
	}
}