﻿
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1307:The behavior of 'string.Contains(string)' could vary based on the current user's locale settings. Replace this call in 'DataX.Flow.SqlParser.SqlParser.Analyze(string, string, string, bool)' with a call to 'string.Contains(string, System.StringComparison)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Flow.SqlParser.SqlParser.Analyze(System.String,System.String,System.String,System.Boolean)~System.Collections.Generic.List{DataX.Flow.SqlParser.TableData}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member BreakDown does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Flow.SqlParser.SqlParser.BreakDown(System.String)~System.Collections.Generic.List{System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member ExtractContent does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Flow.SqlParser.SqlParser.ExtractContent(System.String,System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member GetColumnName does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Flow.SqlParser.SqlParser.GetColumnName(System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1307:The behavior of 'string.Replace(string, string)' could vary based on the current user's locale settings. Replace this call in 'DataX.Flow.SqlParser.SqlParser.GetColumnName(string)' with a call to 'string.Replace(string, string, System.StringComparison)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Flow.SqlParser.SqlParser.GetColumnName(System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member GetTables does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Flow.SqlParser.SqlParser.GetTables(System.String)~System.Collections.Generic.List{System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1304:The behavior of 'string.ToLower()' could vary based on the current user's locale settings. Replace this call in 'SqlParser.IsKeywordStatement(string, string)' with a call to 'string.ToLower(CultureInfo)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Flow.SqlParser.SqlParser.IsKeywordStatement(System.String,System.String)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member IsKeywordStatement does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Flow.SqlParser.SqlParser.IsKeywordStatement(System.String,System.String)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2227:Change 'fields' to be read-only by removing the property setter.", Justification = "Critical issues only", Scope = "member", Target = "~P:DataX.Flow.SqlParser.InputSchema.fields")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2227:Change 'Columns' to be read-only by removing the property setter.", Justification = "Critical issues only", Scope = "member", Target = "~P:DataX.Flow.SqlParser.TableData.Columns")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1724:The type name Metadata conflicts in whole or in part with the namespace name 'System.Runtime.Remoting.Metadata' defined in the .NET Framework. Rename the type to eliminate the conflict.", Justification = "Critical issues only", Scope = "type", Target = "~T:DataX.Flow.SqlParser.Metadata")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1724:The type name SqlParser conflicts in whole or in part with the namespace name 'DataX.Flow.SqlParser'. Change either name to eliminate the conflict.", Justification = "Critical issues only", Scope = "type", Target = "~T:DataX.Flow.SqlParser.SqlParser")]