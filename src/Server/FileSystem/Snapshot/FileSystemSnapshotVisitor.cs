﻿// Copyright 2013 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System;
using System.Collections.Generic;
using VsChromium.Core.Linq;
using VsChromium.Server.FileSystemNames;

namespace VsChromium.Server.FileSystem.Snapshot {
  public class FileSystemSnapshotVisitor {
    private readonly FileSystemSnapshot _snapshot;

    public FileSystemSnapshotVisitor(FileSystemSnapshot snapshot) {
      _snapshot = snapshot;
    }

    public Action<DirectorySnapshot> VisitDirectory { get; set; }
    public Action<FileName> VisitFile { get; set; }

    public void Visit() {
      _snapshot.ProjectRoots.ForAll(x => VisitWorker(x));
    }

    private void VisitWorker(DirectorySnapshot entry) {
      var stack = new Stack<DirectorySnapshot>();
      stack.Push(entry);
      while (stack.Count > 0) {
        var head = stack.Pop();
        VisitDirectory(head);
        head.Files.ForAll(x => VisitFile(x));
        head.DirectoryEntries.ForAll(x => stack.Push(x));
      }
    }
  }
}