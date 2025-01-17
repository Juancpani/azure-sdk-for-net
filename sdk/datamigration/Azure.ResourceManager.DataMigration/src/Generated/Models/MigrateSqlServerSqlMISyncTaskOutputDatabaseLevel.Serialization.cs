// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel
    {
        internal static MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel DeserializeMigrateSqlServerSqlMISyncTaskOutputDatabaseLevel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sourceDatabaseName = default;
            Optional<DatabaseMigrationState> migrationState = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<BackupSetInfo> fullBackupSetInfo = default;
            Optional<BackupSetInfo> lastRestoredBackupSetInfo = default;
            Optional<IReadOnlyList<BackupSetInfo>> activeBackupSets = default;
            Optional<string> containerName = default;
            Optional<string> errorPrefix = default;
            Optional<bool> isFullBackupRestored = default;
            Optional<IReadOnlyList<ReportableException>> exceptionsAndWarnings = default;
            Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceDatabaseName"u8))
                {
                    sourceDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationState = new DatabaseMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fullBackupSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fullBackupSetInfo = BackupSetInfo.DeserializeBackupSetInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("lastRestoredBackupSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastRestoredBackupSetInfo = BackupSetInfo.DeserializeBackupSetInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("activeBackupSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BackupSetInfo> array = new List<BackupSetInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackupSetInfo.DeserializeBackupSetInfo(item));
                    }
                    activeBackupSets = array;
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorPrefix"u8))
                {
                    errorPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isFullBackupRestored"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isFullBackupRestored = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("exceptionsAndWarnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    exceptionsAndWarnings = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel(id.Value, resultType, sourceDatabaseName.Value, Optional.ToNullable(migrationState), Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), fullBackupSetInfo.Value, lastRestoredBackupSetInfo.Value, Optional.ToList(activeBackupSets), containerName.Value, errorPrefix.Value, Optional.ToNullable(isFullBackupRestored), Optional.ToList(exceptionsAndWarnings));
        }
    }
}
