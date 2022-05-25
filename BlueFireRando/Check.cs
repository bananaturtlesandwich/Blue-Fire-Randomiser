namespace BlueFireRando;
public struct Chest
{
    public Chest(string objectName, bool needsHeight, bool needsDash, bool needsWalljump)
    {
        ObjectName = objectName;
        NeedsHeight = needsHeight;
        NeedsDash = needsDash;
        NeedsWalljump = needsWalljump;
    }

    public bool CanGet(bool HasHeight, bool HasDash, bool HasWalljump) =>
        !(HasHeight ^ NeedsHeight) && !(HasDash ^ NeedsDash) && !(HasWalljump ^ NeedsWalljump);

    public string ObjectName = "";
    public bool NeedsHeight;
    public bool NeedsDash;
    public bool NeedsWalljump;
}