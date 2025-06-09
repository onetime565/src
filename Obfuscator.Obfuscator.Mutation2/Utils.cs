using dnlib.DotNet.Emit;

namespace Obfuscator.Obfuscator.Mutation2;

public class Utils
{
	public static bool CheckArithmetic(Instruction instruction)
	{
		if (!instruction.IsLdcI4())
		{
			return false;
		}
		if (instruction.GetLdcI4Value() <= 1)
		{
			return false;
		}
		return true;
	}
}
