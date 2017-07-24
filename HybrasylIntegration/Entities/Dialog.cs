using System.Collections.Generic;

namespace Hybrasyl.Entities
{
    public class DialogSequence
    {
        public List<Dialog> Dialogs { get; private set; }
        public string Name { get; private set; }
        public uint? Id { get; set; }
        public WorldObject Associate { get; private set; }
        

        public DialogSequence(string sequenceName)
        {
            Name = sequenceName;
            Dialogs = new List<Dialog>();
            Id = null;
        }
    }

    public class Dialog
    {
        protected ushort DialogType;
        public DialogSequence Sequence { get; private set; }
        public int Index;
        public string DisplayText { get; protected set; }
        public ushort DisplaySprite { get; set; }

        public Dialog(DialogTypes dialogType, string displayText = null)
        {
            DialogType = (ushort) dialogType;
            DisplayText = displayText;
            
            DisplaySprite = 0;
        }
    }

    public class DialogOption
    {
        public string OptionText { get; private set; }
        private Dialog ParentDialog { get; set; }


        public DialogOption(string option,  Dialog parentdialog = null)
        {
            OptionText = option;
            ParentDialog = parentdialog;
        }

    }

    public class FunctionDialog : Dialog
    {
        public object Function { get; set; }

        public FunctionDialog(object function)
                : base(DialogTypes.FUNCTION_DIALOG)
        {
            Function = function;
        }
    }

    public class SimpleDialog : Dialog
    {
        public SimpleDialog(string displayText)
            : base(DialogTypes.SIMPLE_DIALOG, displayText)
        {

        }
    }

    public class InputDialog : Dialog
    {
        public object Handler { get; private set; }

        public InputDialog(DialogTypes dialogType, string displayText)
            : base(dialogType, displayText)
        {
            Handler = null;
        }
    }

    public class OptionsDialog : InputDialog
    {
        protected List<DialogOption> Options { get; set; }

        public OptionsDialog(string displayText)
            : base(DialogTypes.OPTIONS_DIALOG, displayText)
        {
            Options = new List<DialogOption>();
        }

    }

    public class TextDialog : InputDialog
    {
        public string TopCaption { get; set; }
        public string BottomCaption { get; set; }
        public int InputLength { get; set; }

        public TextDialog(string displayText, string topCaption, string bottomCaption, int inputLength)
            : base(DialogTypes.INPUT_DIALOG, displayText)
        {
            TopCaption = topCaption;
            BottomCaption = bottomCaption;
            InputLength = inputLength;
        }
    }

    public class DialogState
    {
        internal WorldObject Associate { get; private set; }
        internal Dialog ActiveDialog { get; private set; }
        internal DialogSequence ActiveDialogSequence { get; private set; }
        internal User User { get; private set; }

        public uint CurrentPursuitId
        {
            get
            {
                if (InDialog) return ActiveDialogSequence.Id ?? default(int);
                return 0;
            }
        }

        public int CurrentPursuitIndex
        {
            get
            {
                if (InDialog) return ActiveDialog.Index;
               return -1;
            }
        }

        public int CurrentMerchantId
        {
            get
            {
                if (InDialog) return (int)Associate.Id;
                return -1;
            }

        }

        public bool InDialog => (Associate != null && ActiveDialog != null && ActiveDialogSequence != null);

        public DialogState(User user)
        {
            Associate = null;
            ActiveDialog = null;
            ActiveDialogSequence = null;
            User = user;
        }
    }

}
