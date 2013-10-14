using Caliburn.Micro;
using Tail.Extensibility;

namespace Tail.Providers.ZeroMq.ViewModels
{
	public sealed class ZeroMqConfigurationViewModel : Screen, ITailConfiguration
	{
		private string _url;
		private string _validationError;

		public string Url
		{
            get { return _url; }
			set
			{
				_url = value;
				this.NotifyOfPropertyChange(() => Url);
				this.Validate();
			}
		}

		public string ValidationError
		{
			get { return _validationError; }
			set
			{
				_validationError = value;
				this.NotifyOfPropertyChange(() => ValidationError);
			}
		}

		public bool Validate()
		{
			this.ValidationError = string.Empty;
			return true;
		}

        public ZeroMqContext GetContext()
		{
			return new ZeroMqContext(_url);
		}
	}
}
