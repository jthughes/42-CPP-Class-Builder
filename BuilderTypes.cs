namespace CPP_Class_Builder;

public class MethodItem
{
    public string Name { get; set; } = "";
    public string AccessLevel { get; set; } = "public";
	public bool IsStatic { get; set; } = false;
    public bool IsVirtual { get; set; } = false;
    public bool IsPure { get; set; } = false;
    public string ReturnType { get; set; } = "";
	public bool IsConst { get; set; } = false;
}

public class PropertyItem
{
    public string Name { get; set; } = "";
    public string Type { get; set; } = "";
    public string DefaultValue { get; set; } = "";
    public string AccessLevel { get; set; } = "private";
    public bool IsStatic { get; set; } = false;
    public bool IsConst { get; set; } = false;
    public bool HasGetter { get; set; } = false;
    public bool HasSetter { get; set; } = false;
}
