import csv

# CSVファイルを開く
with open('OverTime02.csv', mode='r', encoding='utf-8') as file:
    reader = csv.reader(file)
    
    # ヘッダー行をスキップし、2024/08/30が含まれる行を探す
    for row in reader:
        if '2024/08/30' in row:
            target_column = row.index('2024/08/30')
            break

    # N-Eary行の値を取得
    for row in reader:
        if row[0] == 'N-Eary':
            target_value = row[target_column]
            break

print(f'N-Eary行、2024/08/30列の値: {target_value}')

