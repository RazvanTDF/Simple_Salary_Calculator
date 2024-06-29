# Salary Calculator Windows Forms Application

This is a Windows Forms application designed to calculate the net salary after deducting various contributions from the gross salary. The application validates the input to ensure it contains only numbers. Upon pressing the "Calculate" button, it calculates and displays the contributions, and converts the gross salary to words in Romanian.

## Features

- **Gross Salary Input**: Users can enter the gross salary, which is validated to contain only digits.
- **Contributions Calculation**: Calculates various employee and employer contributions based on predefined formulas.
- **Gross Salary in Words**: Displays the gross salary in Romanian words.

## Formulas

The following formulas are used for calculations:

- **Employee Contributions**:
  - `CFS_angajat = (sbrut / 1000) * 5`
  - `CAS_angajat = (sbrut / 1000) * 105`
  - `CASS_angajat = (sbrut / 1000) * 55`
  - `Impozit_angajat = ((sbrut - CFS_angajat - CAS_angajat - CASS_angajat - 180) / 1000) * 160`

- **Employer Contributions**:
  - `CAS_angajator = (sbrut / 1000) * 208`
  - `CFS_angajator = (sbrut / 1000) * 50`
  - `CFCI = (sbrut / 1000) * 85`
  - `CFGPCS = (sbrut / 10000) * 25`
  - `CASS_angajator = (sbrut / 1000) * 52`
  - `CFAMBP = (sbrut / 1000) * 4`

## Technologies Used

- **C#**
- **Windows Forms**
