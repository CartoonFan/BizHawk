using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BizHawk.Client.EmuHawk.Properties
{
	internal static class Resources
	{
		/// <param name="filename">Dir separator is '<c>.</c>'. Filename is relative to <c>&lt;NS>/images</c> and omits <c>.png</c> extension.</param>
		private static Bitmap ReadEmbeddedBitmap(string filename) => new Bitmap(EmuHawk.ReflectionCache.EmbeddedResourceStream($"images.{filename}.png"));

		/// <param name="filename">Dir separator is '<c>.</c>'. Filename is relative to <c>&lt;NS>/images</c> and omits <c>.ico</c> extension.</param>
		private static Icon ReadEmbeddedIcon(string filename) => new Icon(EmuHawk.ReflectionCache.EmbeddedResourceStream($"images.{filename}.ico"));

		/// <param name="filename">Dir separator is '<c>.</c>'. Filename is relative to <c>&lt;NS>/images</c> and omits <c>.ico</c> extension.</param>
		private static Bitmap ReadEmbeddedIconAsBitmap(string filename) => new Bitmap(EmuHawk.ReflectionCache.EmbeddedResourceStream($"images.{filename}.ico"));

		internal static readonly Lazy<Bitmap> A78Joystick = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.A78Joystick"));
		internal static readonly Lazy<Bitmap> AmigaKeyboard = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.AmigaKeyboard"));
		internal static readonly Lazy<Bitmap> AppleIIKeyboard = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.AppleIIKeyboard"));
		internal static readonly Lazy<Bitmap> ArcadeController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.ArcadeController"));
		internal static readonly Lazy<Bitmap> C64Joystick = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.C64Joystick"));
		internal static readonly Lazy<Bitmap> C64Keyboard = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.C64Keyboard"));
		internal static readonly Lazy<Bitmap> ColecoVisionController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.colecovisioncontroller"));
		internal static readonly Lazy<Bitmap> DSController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.DSController"));
		internal static readonly Lazy<Bitmap> GbaController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.GBA_Controller"));
		internal static readonly Lazy<Bitmap> GbController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.GBController"));
		internal static readonly Lazy<Bitmap> GenesisController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.GENController"));
		internal static readonly Lazy<Bitmap> IntVController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.IntVController"));
		internal static readonly Lazy<Bitmap> Lynx = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.Lynx"));
		internal static readonly Lazy<Bitmap> N64 = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.N64"));
		internal static readonly Lazy<Bitmap> NesController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.NES_Controller"));
		internal static readonly Lazy<Bitmap> NgpController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.NGPController"));
		internal static readonly Lazy<Bitmap> PceController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.PCEngineController"));
		internal static readonly Lazy<Bitmap> PsxDualShockController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.psx_dualshock"));
		internal static readonly Lazy<Bitmap> SaturnController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.SaturnController"));
		internal static readonly Lazy<Bitmap> SmsController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.SMSController"));
		internal static readonly Lazy<Bitmap> SnesController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.SNES_Controller"));
		internal static readonly Lazy<Bitmap> TI83Controller = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.TI83_Controller"));
		internal static readonly Lazy<Bitmap> VBoyController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.VBoyController"));
		internal static readonly Lazy<Bitmap> WonderSwanColor = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.WonderSwanColor"));
		internal static readonly Lazy<Bitmap> ZXSpectrumKeyboards = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("ControllerImages.ZXSpectrumKeyboards"));

		internal static readonly Bitmap Add = ReadEmbeddedBitmap("add");
		internal static readonly Bitmap AddEdit = ReadEmbeddedBitmap("AddEdit");
		internal static readonly Bitmap AddWatch = ReadEmbeddedIconAsBitmap("addWatch");
		internal static readonly Bitmap Amiga = ReadEmbeddedBitmap("amiga");
		internal static readonly Bitmap ArrowBlackDown = ReadEmbeddedBitmap("arrow_black_down");
		internal static readonly Lazy<Bitmap> AtariController = new Lazy<Bitmap>(() => ReadEmbeddedBitmap("atari_controller"));
		internal static readonly Bitmap Audio = ReadEmbeddedBitmap("AudioHS");
		internal static readonly Bitmap AudioMuted = ReadEmbeddedBitmap("AudioMuted");
		internal static readonly Bitmap AutoSearch = ReadEmbeddedBitmap("AutoSearch");
		internal static readonly Bitmap Avi = ReadEmbeddedBitmap("AVI");
		internal static readonly Bitmap Back = ReadEmbeddedBitmap("Back");
		internal static readonly Bitmap BackMore = ReadEmbeddedBitmap("BackMore");
		internal static readonly Icon BasicBot = ReadEmbeddedIcon("basicbot");
		internal static readonly Bitmap BasicBotBit = ReadEmbeddedBitmap("basicbotbit");
		internal static readonly Bitmap Blank = ReadEmbeddedBitmap("Blank");
		internal static readonly Cursor BlankCursor = new Cursor(EmuHawk.ReflectionCache.EmbeddedResourceStream("images.BlankCursor.cur"));
		internal static readonly Bitmap BlueDown = ReadEmbeddedBitmap("BlueDown");
		internal static readonly Bitmap BlueUp = ReadEmbeddedBitmap("BlueUp");
		internal static readonly Bitmap Both = ReadEmbeddedBitmap("Both");
		internal static readonly Bitmap Bsnes = ReadEmbeddedBitmap("bsnes");
		internal static readonly Bitmap MelonDS = ReadEmbeddedBitmap("melonDS");
		internal static readonly Icon BugIcon = ReadEmbeddedIcon("Bug");
		internal static readonly Bitmap Bug = ReadEmbeddedBitmap("Bug");
		internal static readonly Bitmap C64Symbol = ReadEmbeddedBitmap("C64Symbol");
		internal static readonly Bitmap Calculator = ReadEmbeddedBitmap("calculator");
		internal static readonly Icon CalculateIcon = ReadEmbeddedIcon("calculator");
		internal static readonly Bitmap Camera = ReadEmbeddedBitmap("camera");
		internal static readonly Bitmap CdLogger = ReadEmbeddedIconAsBitmap("cdlogger");
		internal static readonly Icon CdLoggerIcon = ReadEmbeddedIcon("cdlogger");
		internal static readonly Bitmap Checkbox = ReadEmbeddedBitmap("checkbox");
		internal static readonly Bitmap Circle = ReadEmbeddedBitmap("Circle");
		internal static readonly Bitmap ClearConsole = ReadEmbeddedBitmap("clear_console");
		internal static readonly Bitmap Close = ReadEmbeddedBitmap("Close");
		internal static readonly Icon CommandWindow = ReadEmbeddedIcon("commandWindow");
		internal static readonly Bitmap Connect16X16 = ReadEmbeddedBitmap("connect_16x16");
		internal static readonly Bitmap CopyFolder = ReadEmbeddedBitmap("CopyFolderHS");
		internal static readonly Bitmap CorpHawk = ReadEmbeddedBitmap("corphawk");
		internal static readonly Bitmap CorpHawkSmall = ReadEmbeddedBitmap("CorpHawkSmall");
		internal static readonly Bitmap Cross = ReadEmbeddedBitmap("Cross");
		internal static readonly Bitmap Cut = ReadEmbeddedBitmap("CutHS");
		internal static readonly Bitmap Debugger = ReadEmbeddedBitmap("Debugger");
		internal static readonly Bitmap Delete = ReadEmbeddedBitmap("Delete");
		internal static readonly Icon DualIcon = ReadEmbeddedIcon("dual");
		internal static readonly Bitmap Duplicate = ReadEmbeddedBitmap("Duplicate");
		internal static readonly Bitmap ENE = ReadEmbeddedBitmap("ENE");
		internal static readonly Bitmap Erase = ReadEmbeddedBitmap("Erase");
		internal static readonly Bitmap ESE = ReadEmbeddedBitmap("ESE");
		internal static readonly Bitmap ExclamationRed = ReadEmbeddedBitmap("ExclamationRed");
		internal static readonly Bitmap FFaccept = ReadEmbeddedBitmap("Farm-Fresh_accept");
		internal static readonly Bitmap FFcancel = ReadEmbeddedBitmap("Farm-Fresh_cancel");
		internal static readonly Bitmap FFdelete = ReadEmbeddedBitmap("Farm-Fresh_delete");
		internal static readonly Bitmap FFexclamation = ReadEmbeddedBitmap("Farm-Fresh_exclamation");
		internal static readonly Bitmap FFhelp = ReadEmbeddedBitmap("Farm-Fresh_help");
		internal static readonly Bitmap FFstar = ReadEmbeddedBitmap("Farm-Fresh_star");
		internal static readonly Bitmap FastForward = ReadEmbeddedBitmap("FastForward");
		internal static readonly Bitmap Find = ReadEmbeddedBitmap("FindHS");
		internal static readonly Bitmap Forward = ReadEmbeddedBitmap("Forward");
		internal static readonly Bitmap Freeze = ReadEmbeddedBitmap("Freeze");
		internal static readonly Icon FreezeIcon = ReadEmbeddedIcon("Freeze");
		internal static readonly Bitmap Fullscreen = ReadEmbeddedBitmap("Fullscreen");
		internal static readonly Bitmap Gambatte = ReadEmbeddedBitmap("gambatte");
		internal static readonly Icon GambatteIcon = ReadEmbeddedIcon("gambatte");
		internal static readonly Icon GameControllerIcon = ReadEmbeddedIcon("GameController");
		internal static readonly Bitmap GameController = ReadEmbeddedBitmap("GameController");
		internal static readonly Lazy<Icon> GbaIcon = new Lazy<Icon>(() => ReadEmbeddedIcon("Gameboy Advance (black) icon"));
		internal static readonly Bitmap GenPlus = ReadEmbeddedBitmap("genplus");
		internal static readonly Bitmap GreenCheck = ReadEmbeddedBitmap("GreenCheck");
		internal static readonly Bitmap Hack = ReadEmbeddedBitmap("Hack");
		internal static readonly Bitmap Help = ReadEmbeddedBitmap("Help");
		internal static readonly Bitmap HomeBrew = ReadEmbeddedBitmap("HomeBrew");
		internal static readonly Icon HotKeysIcon = ReadEmbeddedIcon("HotKeys");
		internal static readonly Bitmap HotKeys = ReadEmbeddedBitmap("HotKeys");
		internal static readonly Bitmap Import = ReadEmbeddedBitmap("Import");
		internal static readonly Bitmap InsertSeparator = ReadEmbeddedBitmap("InsertSeparator");
		internal static readonly Bitmap JumpTo = ReadEmbeddedBitmap("JumpTo");
		internal static readonly Bitmap KitchenSink = ReadEmbeddedBitmap("kitchensink");
		internal static readonly Icon LightningIcon = ReadEmbeddedIcon("Lightning");
		internal static readonly Bitmap Lightning = ReadEmbeddedBitmap("Lightning");
		internal static readonly Bitmap LightOff = ReadEmbeddedBitmap("LightOff");
		internal static readonly Bitmap LightOn = ReadEmbeddedBitmap("LightOn");
		internal static readonly Bitmap LoadConfig = ReadEmbeddedBitmap("LoadConfig");
		internal static readonly Icon Logo = ReadEmbeddedIcon("logo");
		internal static readonly Bitmap LuaPictureBox = ReadEmbeddedBitmap("luaPictureBox");
		internal static readonly Bitmap Mame = ReadEmbeddedBitmap("mame");
		internal static readonly Bitmap MessageConfig = ReadEmbeddedBitmap("MessageConfig");
		internal static readonly Bitmap Mgba = ReadEmbeddedBitmap("mgba-16");
		internal static readonly Icon MonitorIcon = ReadEmbeddedIcon("monitor");
		internal static readonly Bitmap Monitor = ReadEmbeddedBitmap("monitor");
		internal static readonly Bitmap MoveBottom = ReadEmbeddedBitmap("MoveBottom");
		internal static readonly Bitmap MoveDown = ReadEmbeddedBitmap("MoveDown");
		internal static readonly Bitmap MoveLeft = ReadEmbeddedBitmap("MoveLeft");
		internal static readonly Bitmap MoveRight = ReadEmbeddedBitmap("MoveRight");
		internal static readonly Bitmap MoveTop = ReadEmbeddedBitmap("MoveTop");
		internal static readonly Bitmap MoveUp = ReadEmbeddedBitmap("MoveUp");
		internal static readonly Icon MsgBoxIcon = ReadEmbeddedIcon("MsgBox");
		internal static readonly Bitmap NE = ReadEmbeddedBitmap("NE");
		internal static readonly Icon NesControllerIcon = ReadEmbeddedIcon("NESControllerIcon");
		internal static readonly Bitmap NewFile = ReadEmbeddedBitmap("NewFile");
		internal static readonly Bitmap NNE = ReadEmbeddedBitmap("NNE");
		internal static readonly Bitmap NNW = ReadEmbeddedBitmap("NNW");
		internal static readonly Bitmap NoConnect16X16 = ReadEmbeddedBitmap("noconnect_16x16");
		internal static readonly Bitmap NW = ReadEmbeddedBitmap("NW");
		internal static readonly Bitmap OpenFile = ReadEmbeddedBitmap("OpenFile");
		internal static readonly Bitmap Paste = ReadEmbeddedBitmap("Paste");
		internal static readonly Bitmap Pause = ReadEmbeddedBitmap("Pause");
		internal static readonly Bitmap Pcb = ReadEmbeddedBitmap("pcb");
		internal static readonly Icon PceIcon = ReadEmbeddedIcon("pce");
		internal static readonly Bitmap Pencil = ReadEmbeddedBitmap("pencil");
		internal static readonly Icon PencilIcon = ReadEmbeddedIcon("pencil");
		internal static readonly Bitmap Clock = ReadEmbeddedBitmap("Clock");
		internal static readonly Bitmap Play = ReadEmbeddedBitmap("Play");
		internal static readonly Bitmap Placeholder = ReadEmbeddedBitmap("placeholder_bitmap");
		internal static readonly Icon PokeIcon = ReadEmbeddedIcon("poke");
		internal static readonly Bitmap Poke = ReadEmbeddedBitmap("poke");
		internal static readonly Bitmap Previous = ReadEmbeddedBitmap("Previous");
		internal static readonly Icon QuickNesIcon = ReadEmbeddedIcon("QuickNes");
		internal static readonly Bitmap QuickNes = ReadEmbeddedBitmap("QuickNes");
		internal static readonly Bitmap ReadOnly = ReadEmbeddedBitmap("ReadOnly");
		internal static readonly Bitmap Reboot = ReadEmbeddedBitmap("reboot");
		internal static readonly Bitmap Recent = ReadEmbeddedBitmap("Recent");
		internal static readonly Bitmap Record = ReadEmbeddedBitmap("RecordHS");
		internal static readonly Bitmap Redo = ReadEmbeddedBitmap("redo");
		internal static readonly Bitmap Refresh = ReadEmbeddedBitmap("Refresh");
		internal static readonly Bitmap Restart = ReadEmbeddedBitmap("restart");
		internal static readonly Bitmap RetroQuestion = ReadEmbeddedBitmap("RetroQuestion");
		internal static readonly Bitmap RewindRecord = ReadEmbeddedBitmap("RewindRecord");
		internal static readonly Bitmap Save = ReadEmbeddedBitmap("Save");
		internal static readonly Bitmap SaveAs = ReadEmbeddedBitmap("SaveAs");
		internal static readonly Bitmap SaveConfig = ReadEmbeddedBitmap("SaveConfig");
		internal static readonly Bitmap Scan = ReadEmbeddedBitmap("Scan");
		internal static readonly Bitmap ScrollTo = ReadEmbeddedBitmap("ScrollTo");
		internal static readonly Bitmap SE = ReadEmbeddedBitmap("SE");
		internal static readonly Bitmap Search = ReadEmbeddedBitmap("search");
		internal static readonly Icon SearchIcon = ReadEmbeddedIcon("search");
		internal static readonly Icon SharkIcon = ReadEmbeddedIcon("Shark");
		internal static readonly Bitmap Shark = ReadEmbeddedBitmap("Shark");
		internal static readonly Icon SmsIcon = ReadEmbeddedIcon("sms-icon");
		internal static readonly Bitmap Snes9X = ReadEmbeddedBitmap("snes9x");
		internal static readonly Bitmap Split = ReadEmbeddedBitmap("Split");
		internal static readonly Bitmap Square = ReadEmbeddedBitmap("Square");
		internal static readonly Bitmap SSE = ReadEmbeddedBitmap("SSE");
		internal static readonly Bitmap SSW = ReadEmbeddedBitmap("SSW");
		internal static readonly Bitmap Stop = ReadEmbeddedBitmap("Stop");
		internal static readonly Bitmap SW = ReadEmbeddedBitmap("SW");
		internal static readonly Icon TAStudioIcon = ReadEmbeddedIcon("TAStudio");
		internal static readonly Bitmap TAStudio = ReadEmbeddedBitmap("TAStudio");
		internal static readonly Bitmap icon_anchor = ReadEmbeddedBitmap("tastudio.icon_anchor");
		internal static readonly Bitmap icon_anchor_lag = ReadEmbeddedBitmap("tastudio.icon_anchor_lag");
		internal static readonly Bitmap icon_marker = ReadEmbeddedBitmap("tastudio.icon_marker");
		internal static readonly Bitmap ts_h_arrow_blue = ReadEmbeddedBitmap("tastudio.ts_h_arrow_blue");
		internal static readonly Bitmap ts_h_arrow_green = ReadEmbeddedBitmap("tastudio.ts_h_arrow_green");
		internal static readonly Bitmap ts_h_arrow_green_blue = ReadEmbeddedBitmap("tastudio.ts_h_arrow_green_blue");
		internal static readonly Bitmap ts_v_arrow_blue = ReadEmbeddedBitmap("tastudio.ts_v_arrow_blue");
		internal static readonly Bitmap ts_v_arrow_green = ReadEmbeddedBitmap("tastudio.ts_v_arrow_green");
		internal static readonly Bitmap ts_v_arrow_green_blue = ReadEmbeddedBitmap("tastudio.ts_v_arrow_green_blue");
		internal static readonly Bitmap TextDoc = ReadEmbeddedBitmap("textdoc");
		internal static readonly Icon TextDocIcon = ReadEmbeddedIcon("textdoc");
		internal static readonly Bitmap ThumbsDown = ReadEmbeddedBitmap("thumbsdown");
		internal static readonly Icon ToolBoxIcon = ReadEmbeddedIcon("ToolBox");
		internal static readonly Bitmap ToolBox = ReadEmbeddedBitmap("ToolBox");
		internal static readonly Bitmap Translation = ReadEmbeddedBitmap("Translation");
		internal static readonly Bitmap Triangle = ReadEmbeddedBitmap("Triangle");
		internal static readonly Bitmap TruncateFromFile = ReadEmbeddedBitmap("TruncateFromFile");
		internal static readonly Bitmap TvIcon = ReadEmbeddedBitmap("tvIcon");
		internal static readonly Bitmap Undo = ReadEmbeddedBitmap("undo");
		internal static readonly Bitmap Unfreeze = ReadEmbeddedBitmap("Unfreeze");
		internal static readonly Bitmap Profile = ReadEmbeddedBitmap("user_blue_small");
		internal static readonly Icon ProfileIcon = ReadEmbeddedIcon("user_blue");
		internal static readonly Bitmap Watch = ReadEmbeddedIconAsBitmap("watch");
		internal static readonly Icon WatchIcon = ReadEmbeddedIcon("watch");
		internal static readonly Bitmap WhiteTriDown = ReadEmbeddedBitmap("whiteTriDown");
		internal static readonly Bitmap WhiteTriLeft = ReadEmbeddedBitmap("whiteTriLeft");
		internal static readonly Bitmap WhiteTriRight = ReadEmbeddedBitmap("whiteTriRight");
		internal static readonly Bitmap WhiteTriUp = ReadEmbeddedBitmap("whiteTriUp");
		internal static readonly Bitmap WNW = ReadEmbeddedBitmap("WNW");
		internal static readonly Bitmap WSW = ReadEmbeddedBitmap("WSW");
		internal static readonly Bitmap YellowDown = ReadEmbeddedBitmap("YellowDown");
		internal static readonly Bitmap YellowLeft = ReadEmbeddedBitmap("YellowLeft");
		internal static readonly Bitmap YellowRight = ReadEmbeddedBitmap("YellowRight");
		internal static readonly Bitmap YellowUp = ReadEmbeddedBitmap("YellowUp");

		internal static Stream GetNotHawkCallSFX()
			=> EmuHawk.ReflectionCache.EmbeddedResourceStream("Resources.nothawk.wav");
	}
}
