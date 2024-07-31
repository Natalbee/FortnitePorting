using Avalonia.Platform.Storage;
using CUE4Parse.UE4.Objects.Core.Misc;
using CUE4Parse.UE4.Versions;
using FluentAvalonia.UI.Media.Animation;
using FortnitePorting.Shared.Models;

namespace FortnitePorting.Shared;

public static class Globals
{
    public static string VersionString => Version.GetDisplayString(EVersionStringType.IdentifierPrefix);
    public static readonly FPVersion Version = new(3, 1, 6, 0, "beta");
    
    public static readonly FilePickerFileType MappingsFileType = new("Unreal Mappings") { Patterns = [ "*.usmap" ] };
    public static readonly FilePickerFileType MP3FileType = new("MP3 Audio") { Patterns = [ "*.mp3" ] };
    public static readonly FilePickerFileType WAVFileType = new("WAF Audio") { Patterns = [ "*.wav" ] };
    public static readonly FilePickerFileType PNGFileType = new("PNG Image") { Patterns = [ "*.png" ] };
    public static readonly FilePickerFileType GIFFileType = new("GIF Image") { Patterns = [ "*.gif" ] };
    public static readonly FilePickerFileType ImageFileType = new("Image") { Patterns = [ "*.png", "*.jpg", "*.jpeg", "*.tga" ] };
    public static readonly FilePickerFileType PlaylistFileType = new("Fortnite Porting Playlist") { Patterns = [ "*.fp.playlist" ] };
    public static readonly FilePickerFileType ChatAttachmentFileType = new("Image") { Patterns = [ "*.png", "*.jpg", "*.jpeg" ] };
    public static readonly FilePickerFileType BlenderFileType = new("Blender") { Patterns = ["blender.exe"] };
    
    public static readonly FGuid ZERO_GUID = new();
    public const string ZERO_CHAR = "0x0000000000000000000000000000000000000000000000000000000000000000";
    
    public const string DISCORD_URL = "https://discord.gg/FortnitePorting";
    public const string GITHUB_URL = "https://github.com/halfuwu/FortnitePorting/tree/v3";
    public const string KOFI_URL = "https://ko-fi.com/halfuwu";
    public const string WIKI_URL = "https://github.com/halfuwu/FortnitePorting/wiki";
}