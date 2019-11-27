using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace kandc.Models
{
    public class Lab1Data
    {
        public Guid Id { get; set; } = Guid.Empty;
		
        public string brandphone { get; set; }

public string model { get; set; }

public int memory { get; set; }

public string colors { get; set; }

 public BaseModelValidationResult Validate()
{
var validationResult = new BaseModelValidationResult();
if (string.IsNullOrWhiteSpace(brandphone)) validationResult.Append($"Name cannot be empty");
if (string.IsNullOrWhiteSpace(model)) validationResult.Append($"model cannot be empty");
if (!(0 < memory && memory < 100)) validationResult.Append($"GroupIndex {memory} is out of range (0..100)");
return validationResult;
}
public override string ToString()
{
return $"{brandphone} {model} from {colors}-{memory}";
}}}
