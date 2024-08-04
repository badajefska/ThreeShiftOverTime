import pandas as pd
from datetime import datetime

def combine_functions(date_str):
    date = datetime.strptime(date_str,'%m/%d/%y')
    weekday = date.strftime('%a')

    date_serial = date - datetime(1899,12,31)
    serial = date_serial.days +1
    char = hex(serial + 6)
    char02 = char[-1]

    threeshiftswork = {
            "1":"L1","2":"L2","3":"L3","4":"L4",
            "5":"H","6":"M1","7":"M2","8":"M3",
            "9":"M4","a":"H","b":"N1","c":"N2",
            "d":"N3","e":"N4","f":"H","0":"H"
     }
    shift = threeshiftswork.get(char02)
    return weekday,shift

df = pd.read_csv('OverTimeManagement.csv')

df['Week'],df['Shift'] = zip(*df['Date'].apply(combine_functions))

df.to_csv('UpdatedOverTimeManagement.csv',index=False)


