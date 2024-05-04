Option Explicit

Sub ShowCalculatorForm()
    frmLoanCalculator.Show
End Sub

Sub clearData()
    Debug.Print "Clearing contents"
    Range("D4").ClearContents
    Range("D5").ClearContents
    Range("D6").ClearContents
    Range("D8").ClearContents
    
End Sub