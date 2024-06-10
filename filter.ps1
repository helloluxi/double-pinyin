$arr = Get-Content full.txt | ? { $_.Length -eq 4 }
Set-Content dp1.txt $arr