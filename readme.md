# Double Pinyin Trainer

The file `dp.txt` contains all natural code double pinyin combinations.
To generate your own double pinyin table, run `dotnet run` and quickly switch to an empty file `full.txt`, wait until the program finishes, then run `filter.ps1` to generate `dp.txt`.

To use:

1. Add to your powershell profile and replace `dp.txt` with the absolute path, and replace 412 if you have a different `dp.txt` file:
```powershell
function dp {
    $arr = Get-Content dp.txt
    while ($true) {
        $random = Get-Random -Minimum 0 -Maximum 412
        $arr[$random]
        # wait any key input
        $x = $host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
    }
}
```
2. Open a powershell terminal and run `dp`
3. Daily practice ^_^
