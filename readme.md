Insert 1.000.000 Rows

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.6899)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-QIDYWO : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1000  IterationCount=100  LaunchCount=1
RunStrategy=ColdStart  UnrollFactor=1  WarmupCount=0

| Method                   | Mean     | Error     | StdDev    | P25      | P50      | P90      | P95      | P100     | Ratio | RatioSD |
|------------------------- |---------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|------:|--------:|
| Uuid_V4_CI               | 1.344 ms | 0.1046 ms | 0.3085 ms | 1.266 ms | 1.297 ms | 1.371 ms | 1.430 ms | 4.000 ms |  1.02 |    0.25 |
| Uuid_V4_NCI              | 1.418 ms | 0.0913 ms | 0.2691 ms | 1.327 ms | 1.362 ms | 1.518 ms | 1.748 ms | 3.721 ms |  1.08 |    0.23 |
| Uuid_V7_CI               | 1.251 ms | 0.0822 ms | 0.2425 ms | 1.200 ms | 1.225 ms | 1.280 ms | 1.317 ms | 3.611 ms |  0.95 |    0.21 |
| Uuid_V7_NCI              | 1.353 ms | 0.0874 ms | 0.2576 ms | 1.271 ms | 1.326 ms | 1.405 ms | 1.427 ms | 3.798 ms |  1.03 |    0.22 |
| Uuid_V7_Text             | 1.451 ms | 0.0904 ms | 0.2666 ms | 1.375 ms | 1.411 ms | 1.519 ms | 1.556 ms | 3.815 ms |  1.10 |    0.23 |
| Uuid_V7_NCI_Binary       | 1.360 ms | 0.0852 ms | 0.2511 ms | 1.293 ms | 1.330 ms | 1.419 ms | 1.444 ms | 3.762 ms |  1.03 |    0.21 |
| Uuid_V7_Binary_BigEndian | 1.477 ms | 0.0893 ms | 0.2632 ms | 1.366 ms | 1.430 ms | 1.725 ms | 1.852 ms | 3.501 ms |  1.12 |    0.23 |
| Ulid_Text                | 1.965 ms | 0.1609 ms | 0.4745 ms | 1.868 ms | 2.003 ms | 2.378 ms | 2.450 ms | 4.960 ms |  1.49 |    0.39 |
| Ulid_Binary              | 1.217 ms | 0.1121 ms | 0.3305 ms | 1.143 ms | 1.179 ms | 1.272 ms | 1.288 ms | 4.435 ms |  0.92 |    0.27 |

* Legends *
  Mean    : Arithmetic mean of all measurements
  Error   : Half of 99.9% confidence interval
  StdDev  : Standard deviation of all measurements
  P25     : Percentile 25
  P50     : Percentile 50
  P90     : Percentile 90
  P95     : Percentile 95
  P100    : Percentile 100
  Ratio   : Mean of the ratio distribution ([Current]/[Baseline])
  RatioSD : Standard deviation of the ratio distribution ([Current]/[Baseline])
  1 ms    : 1 Millisecond (0.001 sec)

Read 

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.6899)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-ZURXSQ : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1000  IterationCount=100  LaunchCount=1
RunStrategy=ColdStart  UnrollFactor=1  WarmupCount=0

| Method                   | Mean     | Error    | StdDev   | P25      | P50      | P90      | P95      | P100       | Ratio | RatioSD |
|------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|-----------:|------:|--------:|
| Uuid_V4_CI               | 637.5 us | 61.50 us | 181.3 us | 593.6 us | 611.8 us | 651.5 us | 719.3 us | 2,283.0 us |  1.03 |    0.31 |
| Uuid_V4_NCI              | 592.3 us | 56.35 us | 166.2 us | 555.7 us | 572.9 us | 586.9 us | 600.0 us | 2,051.3 us |  0.96 |    0.29 |
| Uuid_V7_CI               | 618.0 us | 59.44 us | 175.3 us | 553.0 us | 597.1 us | 660.6 us | 692.1 us | 2,114.5 us |  1.00 |    0.30 |
| Uuid_V7_NCI              | 550.2 us | 62.42 us | 184.1 us | 503.2 us | 523.0 us | 573.6 us | 590.3 us | 2,160.0 us |  0.89 |    0.31 |
| Uuid_V7_Text             | 746.5 us | 60.39 us | 178.1 us | 685.9 us | 715.2 us | 772.0 us | 822.8 us | 2,269.5 us |  1.20 |    0.31 |
| Uuid_V7_NCI_Binary       | 595.8 us | 57.61 us | 169.9 us | 546.2 us | 572.1 us | 611.7 us | 642.0 us | 2,119.8 us |  0.96 |    0.29 |
| Uuid_V7_Binary_BigEndian | 627.0 us | 59.23 us | 174.6 us | 585.2 us | 609.1 us | 647.7 us | 662.1 us | 2,175.2 us |  1.01 |    0.30 |
| Ulid_Text                | 708.0 us | 60.35 us | 177.9 us | 649.5 us | 692.3 us | 739.5 us | 747.2 us | 2,263.1 us |  1.14 |    0.31 |
| Ulid_Binary              | 580.7 us | 61.45 us | 181.2 us | 534.6 us | 544.4 us | 606.7 us | 623.1 us | 2,198.3 us |  0.94 |    0.31 |

Index Rebuild
Read

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.6899)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-AIQOFG : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1000  IterationCount=100  LaunchCount=1
RunStrategy=ColdStart  UnrollFactor=1  WarmupCount=0

| Method                   | Mean     | Error    | StdDev   | P25      | P50      | P90      | P95      | P100       | Ratio | RatioSD |
|------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|-----------:|------:|--------:|
| Uuid_V4_CI               | 599.9 us | 62.17 us | 183.3 us | 552.6 us | 570.9 us | 621.9 us | 642.5 us | 2,188.4 us |  1.03 |    0.34 |
| Uuid_V4_NCI              | 574.3 us | 56.97 us | 168.0 us | 533.0 us | 550.8 us | 585.5 us | 624.0 us | 2,046.3 us |  0.99 |    0.31 |
| Uuid_V7_CI               | 602.1 us | 61.34 us | 180.9 us | 554.0 us | 574.5 us | 612.3 us | 619.3 us | 2,183.2 us |  1.04 |    0.33 |
| Uuid_V7_NCI              | 573.3 us | 59.22 us | 174.6 us | 527.7 us | 553.0 us | 598.8 us | 614.1 us | 2,156.2 us |  0.99 |    0.32 |
| Uuid_V7_Text             | 696.3 us | 56.77 us | 167.4 us | 653.1 us | 677.0 us | 731.7 us | 737.9 us | 2,191.6 us |  1.20 |    0.32 |
| Uuid_V7_NCI_Binary       | 581.6 us | 59.62 us | 175.8 us | 537.0 us | 554.3 us | 596.2 us | 612.0 us | 2,167.2 us |  1.00 |    0.33 |
| Uuid_V7_Binary_BigEndian | 577.8 us | 60.15 us | 177.3 us | 527.1 us | 561.3 us | 598.1 us | 611.1 us | 2,070.9 us |  1.00 |    0.33 |
| Ulid_Text                | 673.9 us | 61.03 us | 180.0 us | 617.8 us | 652.6 us | 709.3 us | 725.7 us | 2,240.0 us |  1.16 |    0.34 |
| Ulid_Binary              | 598.6 us | 61.82 us | 182.3 us | 557.7 us | 585.2 us | 621.7 us | 639.6 us | 2,154.5 us |  1.03 |    0.34 |

Read with defaults

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.6899)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-CFFYGG : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

RunStrategy=Throughput

| Method                   | Mean     | Error    | StdDev   | P25      | P50      | P90      | P95      | P100     | Ratio | RatioSD |
|------------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|------:|--------:|
| Uuid_V4_CI               | 588.9 us | 12.95 us | 37.99 us | 563.3 us | 581.5 us | 642.8 us | 647.7 us | 690.2 us |  1.00 |    0.09 |
| Uuid_V4_NCI              | 559.7 us | 15.39 us | 45.37 us | 533.4 us | 565.0 us | 618.9 us | 631.9 us | 662.5 us |  0.95 |    0.10 |
| Uuid_V7_CI               | 585.9 us | 13.28 us | 39.17 us | 558.0 us | 585.0 us | 640.2 us | 656.4 us | 676.1 us |  1.00 |    0.09 |
| Uuid_V7_NCI              | 549.4 us | 10.93 us | 30.47 us | 530.8 us | 550.1 us | 586.1 us | 588.9 us | 615.1 us |  0.94 |    0.08 |
| Uuid_V7_Text             | 717.0 us | 14.23 us | 34.36 us | 699.8 us | 722.1 us | 752.8 us | 758.8 us | 781.7 us |  1.22 |    0.10 |
| Uuid_V7_NCI_Binary       | 536.8 us | 10.66 us | 27.14 us | 518.4 us | 537.2 us | 570.2 us | 586.9 us | 601.8 us |  0.92 |    0.07 |
| Uuid_V7_Binary_BigEndian | 594.5 us | 11.85 us | 33.99 us | 579.8 us | 594.6 us | 634.6 us | 645.8 us | 670.0 us |  1.01 |    0.09 |
| Ulid_Text                | 690.6 us | 13.70 us | 35.86 us | 668.2 us | 688.9 us | 740.7 us | 748.5 us | 773.3 us |  1.18 |    0.10 |
| Ulid_Binary              | 598.6 us | 11.76 us | 23.76 us | 584.5 us | 595.2 us | 626.6 us | 637.9 us | 656.1 us |  1.02 |    0.08 |